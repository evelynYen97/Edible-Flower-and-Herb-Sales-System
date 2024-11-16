using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 個人專題.Inherit;

namespace 個人專題.Orders
{
    public partial class frmOrderEdit : frmEditAdd
    {
        string strNewODesc = "";
        string strNewPayment = "";

        public frmOrderEdit()
        {
            InitializeComponent();
        }

        private void frmOrderEdit_Load(object sender, EventArgs e)
        {
            lblOID.Text = Global_var.intOID.ToString();
        }

        private void radioDelivery_CheckedChanged(object sender, EventArgs e)
        {
            strNewODesc = " Delivery order";
        }

        private void radioRDelivery_CheckedChanged(object sender, EventArgs e)
        {
            strNewODesc = " Reservation Delivery order";
        }

        private void radioSelf_CheckedChanged(object sender, EventArgs e)
        {
            strNewODesc = " Self-pickup Order";
        }

        private void radioRSelf_CheckedChanged(object sender, EventArgs e)
        {
            strNewODesc = "Reservation Self-pickup Order";
        }

        private void radioCash_CheckedChanged(object sender, EventArgs e)
        {
            strNewPayment = "Cash";
        }

        private void radioCredit_CheckedChanged(object sender, EventArgs e)
        {
            strNewPayment = "Credit";
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (strNewODesc != "" && strNewPayment != "")
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL2 = "UPDATE order_list\r\nSET odesc=@OrderDesc,paymentStatus=@Pay\r\nWHERE onum=@OID;";
                SqlCommand cmd = new SqlCommand(strSQL2, con);
                cmd.Parameters.AddWithValue("@OrderDesc", strNewODesc);
                cmd.Parameters.AddWithValue("@Pay", strNewPayment);
                cmd.Parameters.AddWithValue("@OID", Global_var.intOID.ToString());
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"Update successfully. Rows changed:{rows}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose order description and mode of payment.");
            }
        }
    }
}
