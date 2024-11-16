using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 個人專題.Pos;

namespace 個人專題
{
    public partial class frmCheckOut : frmOrderlistAdd
    {
        int intSubtotal = 0;

        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            lblClient.Text=Global_var.str訂購人姓名;
            lblShipping.Text = Global_var.strDeliveryWayChoose;
            加載購物車内容();
            lblShippingPrice.Text=Global_var.intDeliveryPrice.ToString();
            計算總價();
        }

        void 計算總價()
        {
            int intDiscount = 0;
            int intShippingDiscount = 0;
            Int32.TryParse(lblDiscount.Text, out intDiscount);
            Int32.TryParse(lblShippingDisCount.Text, out intShippingDiscount);
            List<int> listTotalPrice = new List<int>();
            listTotalPrice.Add(Global_var.intDeliveryPrice);
            listTotalPrice.Add(intDiscount);
            listTotalPrice.Add(intShippingDiscount);
            listTotalPrice.Add(intSubtotal);
            int intTotalPrice = listTotalPrice.Sum();
            lblTotalPrice.Text = intTotalPrice.ToString();
        }

        void 加載購物車内容()
        {
            List<int> listSubTotal = new List<int>();
            List<int> listAmountTotal = new List<int>();
            lBoxOrderDetails.Items.Clear();
            foreach (ArrayList item in Global_var.listOrderItems)
            {
                string PName = (string)item[0];
                int SpecificationID = (int)item[1];
                int Amount = (int)item[2];
                int Price = (int)item[3];
                double Weight = (double)item[4];
                int Container = (int)item[5];
                int Total = Amount * Price;
                listSubTotal.Add(Total);
                listAmountTotal.Add(Amount);
                lBoxOrderDetails.Items.Add($"{PName} {Container} oz {Weight} g x {Amount}");
            }
            int intAmount = listAmountTotal.Sum();
            intSubtotal = listSubTotal.Sum();
            lblSubtotal.Text = $"Subtotal({intAmount} items) : $ {intSubtotal}";
            lblItemPrice.Text = $"{intSubtotal}";
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strPaymentChoose = "Cash";
        }

        private void radioCredit_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strPaymentChoose = "Credit";
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (Global_var.strPaymentChoose != "")
            {
                if (Global_var.date預訂供貨日 != default)
                {
                    string strSQL = "INSERT INTO order_list \r\nVALUES (@OrderDate,@SupplyDate,@OrderDesc,@Total,@Pay,@Status);";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    string strDateTime = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.AddWithValue("@OrderDate", strDateTime);
                    cmd.Parameters.AddWithValue("@SupplyDate", Global_var.date預訂供貨日);
                    string strOrderDesc = $"{Global_var.strReservation} {Global_var.str送貨方式}";
                    cmd.Parameters.AddWithValue("@OrderDesc",strOrderDesc);
                    cmd.Parameters.AddWithValue("@Total", lblTotalPrice.Text);
                    cmd.Parameters.AddWithValue("@Pay", Global_var.strPaymentChoose);
                    string strStatus = "Unconfirmed";
                    cmd.Parameters.AddWithValue("@Status", strStatus);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    寫入訂單明細();
                    MessageBox.Show($"Order added successfully.");
                    this.Close();
                }
                else 
                {
                    if(Global_var.date供貨日 != default)
                    {
                        string strSQL = "INSERT INTO order_list \r\nVALUES (@OrderDate,@SupplyDate,@OrderDesc,@Total,@Pay,@Status);";
                        SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        string strDateTime = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.AddWithValue("@OrderDate", strDateTime);
                        cmd.Parameters.AddWithValue("@SupplyDate", Global_var.date供貨日);
                        string strOrderDesc = $"{Global_var.strReservation} {Global_var.str送貨方式}";
                        cmd.Parameters.AddWithValue("@OrderDesc", strOrderDesc);

                        cmd.Parameters.AddWithValue("@Total", lblTotalPrice.Text);
                        cmd.Parameters.AddWithValue("@Pay", Global_var.strPaymentChoose);
                        string strStatus = "Unconfirmed";
                        cmd.Parameters.AddWithValue("@Status", strStatus);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        寫入訂單明細();
                        MessageBox.Show($"Order added successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Date Error.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose one mode of payment.");
            }
        }




        void 寫入訂單明細()
        {
            SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
            conn.Open();
            string strSQL1 = "SELECT cnum FROM clients WHERE companyShortName=@ShortName";
            SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
            cmd1.Parameters.AddWithValue("@ShortName", Global_var.str訂購人姓名);
            SqlDataReader read = cmd1.ExecuteReader();
            int intClientID = 0;
            if (read.HasRows)
            {
                read.Read();
                intClientID = (int)read["cnum"];
            }
            read.Close();
            conn.Close();

            foreach (ArrayList item in Global_var.listOrderItems)
            {
                try
                {
                    string PName = (string)item[0];
                    int SpecificationID = (int)item[1];
                    int Amount = (int)item[2];
                    string strSQL3 = "INSERT INTO order_detail \r\nVALUES (@OrderDate,@ClientID,@PName,@PSID,@Amount);";
                    SqlConnection sqlc = new SqlConnection(Global_var.strDBConnectionString);
                    sqlc.Open();
                    SqlCommand cmd2 = new SqlCommand(strSQL3, sqlc);
                    string strDateTime = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd2.Parameters.AddWithValue("@OrderDate", strDateTime);
                    cmd2.Parameters.AddWithValue("@ClientID", intClientID);
                    cmd2.Parameters.AddWithValue("@PName", PName);
                    cmd2.Parameters.AddWithValue("@PSID", SpecificationID);
                    cmd2.Parameters.AddWithValue("@Amount", Amount);
                    cmd2.ExecuteNonQuery();
                    sqlc.Close();
                }
                catch
                {
                    MessageBox.Show("Order detail input error.");
                }
            }
        }
    }
}
