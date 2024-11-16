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
using System.Windows.Ink;
using 個人專題.Inherit;
using 個人專題.Orders;

namespace 個人專題
{
    public partial class frmHistoryOrders : frmMainViewAdd
    {
        int dgv筆數 = 0;
        string strOID = "";
        public frmHistoryOrders()
        {
            InitializeComponent();
        }

        private void frmHistoryOrders_Load(object sender, EventArgs e)
        {
            cBoxSearch.Items.Add("all");
            cBoxSearch.Items.Add("client name");
            cBoxSearch.Items.Add("order number");
            cBoxSearch.Items.Add("date of order ");
            cBoxSearch.Items.Add("date of delivery");
            cBoxSearch.SelectedIndex = 0;
            string strOID1 = "";
            btnAdd.Visible = false;
            if (Global_var.intUserPrivilege == 3)
            {
                btnReestablish.Visible=true;
                顯示所有資料();
            }
            else
            {
                btnReestablish.Visible = false;
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum \r\nWHERE o.orderStatus ='Completed' OR o.orderStatus ='Cancel'\r\nGROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY orderStatus DESC ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvHistoryOrders.DataSource = dt;
                }
                reader.Close();
                con.Close();
                if (dgvHistoryOrders.Rows.Count > 0)
                {
                    dgvHistoryOrders.CurrentCell = dgvHistoryOrders.Rows[0].Cells[0];
                    dgvHistoryOrders.Rows[0].Selected = true;
                    strOID = dgvHistoryOrders.Rows[0].Cells[0].Value.ToString().Trim();
                    Int32.TryParse(strOID, out Global_var.intOID);
                    string strOrderDate = dgvHistoryOrders.Rows[0].Cells[2].Value.ToString().Trim();
                    DateTime.TryParse(strOrderDate, out Global_var.date下單日);
                    Global_var.strOOrderDate = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            dtpFromDate.Value= DateTime.Now;
            dtpToDate.Value= DateTime.Now;
            if (dgvHistoryOrders.Rows.Count > 0)
            {
                dgvHistoryOrders.CurrentCell = dgvHistoryOrders.Rows[0].Cells[0];
                dgvHistoryOrders.Rows[0].Selected = true;
                strOID1 = dgvHistoryOrders.Rows[0].Cells[0].Value.ToString();
                Int32.TryParse(strOID1, out Global_var.intOID);
            }
        }
        private void 顯示所有資料()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum \r\nWHERE o.orderStatus ='Completed' OR o.orderStatus ='Cancel'\r\nGROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY orderStatus DESC ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvHistoryOrders.DataSource = dt;
            }
            reader.Close();
            con.Close();
            if (dgvHistoryOrders.Rows.Count > 0)
            {
                dgvHistoryOrders.CurrentCell = dgvHistoryOrders.Rows[0].Cells[0];
                dgvHistoryOrders.Rows[0].Selected = true;
                strOID = dgvHistoryOrders.Rows[0].Cells[0].Value.ToString().Trim();
                Int32.TryParse(strOID, out Global_var.intOID);
                string strOrderDate = dgvHistoryOrders.Rows[0].Cells[2].Value.ToString().Trim();
                DateTime.TryParse(strOrderDate, out Global_var.date下單日);
                Global_var.strOOrderDate = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");
            }
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
                cmd.Parameters.AddWithValue("@Search", $"%{txtSearchProducts.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvHistoryOrders.DataSource = dt;
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
                    dgvHistoryOrders.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data available.");
                }
                reader.Close();
                con.Close();
            }
            else if (cBoxSearch.SelectedIndex == 3)
            {
                if ((dtpFromDate.Value != DateTime.Now) && (dtpToDate.Value != DateTime.Now) && (dtpFromDate.Value < dtpToDate.Value))
                {
                    strSQL1 = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status]\r\nFROM order_list o  JOIN order_detail od ON o.odate = od.odate\r\n                   JOIN clients c ON  od.cnum=c.cnum\r\nWHERE CONVERT(datetime, o.odate) BETWEEN @startDate AND @endDate GROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus\r\nORDER BY o.onum desc;";
                    SqlCommand cmd = new SqlCommand(strSQL1, con);
                    cmd.Parameters.AddWithValue("@startDate", dtpFromDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpToDate.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgv筆數 = dt.Rows.Count;
                        Console.WriteLine($"DGV筆數：{dgv筆數}");
                        dgvHistoryOrders.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No data available.");
                    }
                    reader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invaid date.");
                }
            }
            else if (cBoxSearch.SelectedIndex == 4)
            {
                if((dtpFromDate.Value!=DateTime.Now) && (dtpToDate.Value != DateTime.Now) &&(dtpFromDate.Value<dtpToDate.Value))
                {
                    strSQL1 = "SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status] FROM order_list o JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum WHERE o.supplydate BETWEEN @startDate AND @endDate GROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus ORDER BY o.onum desc;";
                    SqlCommand cmd = new SqlCommand(strSQL1, con);
                    cmd.Parameters.AddWithValue("@startDate", dtpFromDate.Value);
                    cmd.Parameters.AddWithValue("@endDate", dtpToDate.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgv筆數 = dt.Rows.Count;
                        Console.WriteLine($"DGV筆數：{dgv筆數}");
                        dgvHistoryOrders.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No data available.");
                    }
                    reader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invaid date.");
                }
            }
        }

        private void dgvHistoryOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                string strOrderDate = dgvHistoryOrders.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                DateTime.TryParse(strOrderDate, out Global_var.date下單日);
                Global_var.strOOrderDate = Global_var.date下單日.ToString("yyyy-MM-dd HH:mm:ss");            }
        }

        private void btnViewOrderDetail_Click(object sender, EventArgs e)
        {
            frmViewOrderDetail myViewOD = new frmViewOrderDetail();
            myViewOD.ShowDialog();
        }

        private void cBoxSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((cBoxSearch.SelectedIndex == 4) || (cBoxSearch.SelectedIndex == 3))
            {
                txtSearchProducts.Enabled = false;
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
            }
            else if (cBoxSearch.SelectedIndex == 0)
            {
                txtSearchProducts.Enabled = false;
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
            else
            {
                txtSearchProducts.Enabled = true;
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void btnReestablish_Click(object sender, EventArgs e)
        {
            string strRebulid = "Unconfirmed";
            DialogResult R = MessageBox.Show("Are you sure to re-establish this order?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intOID > 0)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "UPDATE order_list SET orderStatus=@Rebulid WHERE onum=@OID;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Rebulid", strRebulid);
                    cmd.Parameters.AddWithValue("@OID", Global_var.intOID);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Re-establish successfully. \n {rows} rows of data have changed.");
                }
                else
                {
                    MessageBox.Show("Error.");
                }
                顯示所有資料();
            }
        }
    }
}
