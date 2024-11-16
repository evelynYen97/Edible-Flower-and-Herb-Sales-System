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
using 個人專題.Inherit;
using 個人專題.Orders;

namespace 個人專題
{
    public partial class frmOrders : frmMainViewAdd
    {
        int dgv筆數 = 0;
        string strOID = "";

        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if(Global_var.intUserPrivilege==3 || Global_var.intUserPrivilege == 2)
            {
                btnEdit.Enabled = true;
                btnCancel.Visible = true;
                btnDefer.Visible = true;
            }
            else
            {
                btnEdit.Enabled=false;
                btnCancel.Visible = false;
                btnDefer.Visible = false;
            }
            cBoxSearch.Items.Add("All");
            cBoxSearch.Items.Add("client name");
            cBoxSearch.Items.Add("order number");
            cBoxSearch.SelectedIndex = 0;
            if (Global_var.intUserPrivilege == 3)
            {
                顯示所有資料();
            }
            else
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum \r\nWHERE o.orderStatus ='Unconfirmed'\r\nGROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY O.odate DESC ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvAllOrders.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }
            if (dgvAllOrders.Rows.Count > 0)
            {
                dgvAllOrders.CurrentCell = dgvAllOrders.Rows[0].Cells[0];
                dgvAllOrders.Rows[0].Selected = true;
                strOID = dgvAllOrders.Rows[0].Cells[0].Value.ToString().Trim();
                Int32.TryParse(strOID, out Global_var.intOID);
                string strOrderDate = dgvAllOrders.Rows[0].Cells[2].Value.ToString().Trim();
                DateTime.TryParse(strOrderDate, out Global_var.date下單日);
                Global_var.strOOrderDate = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void 顯示所有資料()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum \r\nWHERE o.orderStatus ='Unconfirmed'\r\nGROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY O.odate DESC ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvAllOrders.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL1 = "";
            if (cBoxSearch.SelectedIndex == 0)
            {
                顯示所有資料();
            }
            else if (cBoxSearch.SelectedIndex == 1)
            {
                strSQL1 = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status] FROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum WHERE c.companyShortName LIKE @Search GROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus ORDER BY o.odate DESC";
                SqlCommand cmd = new SqlCommand(strSQL1, con);
                cmd.Parameters.AddWithValue("@Search",$"%{txtSearchProducts.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvAllOrders.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data available.");
                }
                reader.Close();
                con.Close();
            }
            else if (cBoxSearch.SelectedIndex == 2)
            {
                strSQL1 = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate\r\n                   JOIN clients c ON  od.cnum=c.cnum\r\nWHERE o.onum = @Search GROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY o.onum desc;";
                SqlCommand cmd = new SqlCommand(strSQL1, con);
                cmd.Parameters.AddWithValue("@Search", txtSearchProducts.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvAllOrders.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data available.");
                }
                reader.Close();
                con.Close();
            }
            
        }

        private void dgvAllOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                string strOrderDate = dgvAllOrders.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                DateTime.TryParse(strOrderDate, out Global_var.date下單日);
                Global_var.strOOrderDate = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
                Global_var.strOSupplyDate = dgvAllOrders.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                strOID = dgvAllOrders.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                Int32.TryParse(strOID, out Global_var.intOID);
            }
        }

        private void frmOrders_Activated(object sender, EventArgs e)
        {
            cBoxSearch.SelectedIndex = 0;
            顯示所有資料();
        }

        private void btnDefer_Click(object sender, EventArgs e)
        {
            frmDeferOrder myDeferOrder = new frmDeferOrder();
            myDeferOrder.ShowDialog();
            顯示所有資料();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure to cancel this order?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intOID > 0)
                {
                    string strCancel = "Cancel";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "UPDATE order_list SET orderStatus=@Cancel WHERE onum=@OID;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Cancel",strCancel);
                    cmd.Parameters.AddWithValue("@OID", strOID);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Order status changed successfully. \n {rows} rows of data have changed.");
                    cBoxSearch.SelectedIndex = 0;
                    顯示所有資料();
                }
                else
                {
                    MessageBox.Show("Error. No data is selected.");
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure to complete this order?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intOID > 0)
                {
                    string strComplete = "Completed";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "UPDATE order_list SET orderStatus=@Cancel,supplydate=@DateFinish WHERE onum=@OID;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Cancel", strComplete);
                    cmd.Parameters.AddWithValue("@OID", strOID);
                    cmd.Parameters.AddWithValue("@DateFinish", DateTime.Now);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Order completed. \n {rows} rows of data have changed.");
                    cBoxSearch.SelectedIndex = 0;
                    顯示所有資料();
                }
                else
                {
                    MessageBox.Show("Error. No data is selected.");
                }
            }
        }

        private void cBoxSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cBoxSearch.SelectedIndex == 0)
            {
                txtSearchProducts.Enabled = false;
            }
            else 
            {
                txtSearchProducts.Enabled = true;
            }
        }

        private void btnViewODetails_Click(object sender, EventArgs e)
        {
            frmViewOrderDetail myViewOrderDetail = new frmViewOrderDetail();
            myViewOrderDetail.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            frmOrderEdit myOrderEdit = new frmOrderEdit();
            myOrderEdit.ShowDialog();
        }
    }
}
