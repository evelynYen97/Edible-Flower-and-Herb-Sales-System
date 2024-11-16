using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 個人專題
{
    public partial class frmHome1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strSQL = "";
        int dgv筆數 = 0;
        int intTotalRevenue = 0;

        public frmHome1()
        {
            InitializeComponent();
        }

        private void frmHome1_Load(object sender, EventArgs e)
        {
            Global_var.dateFrom = DateTime.Today.AddDays(-30);
            Global_var.dateTo = DateTime.Today.AddDays(1).AddTicks(-1);
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
            strSQL = "SELECT pNum ID,productsName [Products Name],productsSeedStock [Seed stock] FROM products WHERE productsSeedStock <=5;";
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SelectID", Global_var.intIDChoose);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt1 = new DataTable();
                dt1.Load(reader);
                dgv筆數 = dt1.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvProductsUnderstock.DataSource = dt1;
            }
            reader.Close();
            con.Close();
            LoadData();
        }

        private void LoadData()
        {
            strSQL = "SELECT COUNT(*) FROM staff;";
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd= new SqlCommand(strSQL, con);
            int staffcount=(int)cmd.ExecuteScalar();
            lblTotalStaffs.Text = staffcount.ToString();
            strSQL = "SELECT COUNT(*) FROM clients;";
            cmd = new SqlCommand(strSQL, con);
            int Clientscount = (int)cmd.ExecuteScalar();
            lblTotalClients.Text = Clientscount.ToString();
            strSQL = "SELECT COUNT(*) FROM products;";
            cmd = new SqlCommand(strSQL, con);
            int Productscount = (int)cmd.ExecuteScalar();
            lblTotalProducts.Text = Productscount.ToString();
            con.Close();
            loadChartProduct();
            loadChartRevenue();
        }

        void loadChartProduct()
        {
            SqlConnection con3 = new SqlConnection(Global_var.strDBConnectionString);
            con3.Open();
            strSQL = "SELECT TOP 5 pname, SUM(pamount) AS TotalSold FROM order_detail WHERE odate BETWEEN @FromDate AND @EndDate GROUP BY pname ORDER BY TotalSold DESC;";
            SqlCommand cmd3 = new SqlCommand(strSQL, con3);
            cmd3.Parameters.AddWithValue("@FromDate", Global_var.dateFrom);
            cmd3.Parameters.AddWithValue("@EndDate", Global_var.dateTo);
            SqlDataReader reader = cmd3.ExecuteReader();
            chartTop5Products.Series["Sales volume"].Points.Clear();
            while (reader.Read())
            {
                string productName = reader["pname"].ToString();
                int totalSold = Convert.ToInt32(reader["TotalSold"]);
                chartTop5Products.Series["Sales volume"].Points.AddXY(productName, totalSold);
                //chartTop5Products.Series["Sales volume"].XValueMember = "pname";
            }
            reader.Close();
            con3.Close();
            chartTop5Products.Invalidate();
        }

        void loadChartRevenue()
        {
            SqlConnection con4 = new SqlConnection(Global_var.strDBConnectionString);
            con4.Open();
            strSQL = "SELECT CAST(supplydate AS DATE) AS SaleDate,SUM(ototal) AS TotalSold FROM order_list WHERE odate BETWEEN @FromDate AND @EndDate AND orderStatus='Completed' GROUP BY CAST(supplydate AS DATE)";
            SqlCommand cmd3 = new SqlCommand(strSQL, con4);
            cmd3.Parameters.AddWithValue("@FromDate", Global_var.dateFrom);
            cmd3.Parameters.AddWithValue("@EndDate", Global_var.dateTo);
            SqlDataReader reader = cmd3.ExecuteReader();
            chartRevenue.Series["Daily sales"].Points.Clear();
            while (reader.Read())
            {
                DateTime dateWant=Convert.ToDateTime(reader["SaleDate"]);
                string XName = dateWant.ToString("yyyy-MM-dd");
                int totalSold = Convert.ToInt32(reader["TotalSold"]);
                chartRevenue.Series["Daily sales"].Points.AddXY(XName, totalSold);
            }
            reader.Close();
            con4.Close();
            chartRevenue.Invalidate();
        }

        private void BaseColorChange(Button btnSelect)
        {
            btnCustom.BackColor= Color.WhiteSmoke;
            btnToday.BackColor= Color.WhiteSmoke;
            btnLast7.BackColor= Color.WhiteSmoke;
            btnLast30.BackColor= Color.WhiteSmoke;
            btnSelect.BackColor = Color.PowderBlue;

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled=true;
            dtpTo.Enabled=true;
            BaseColorChange(btnCustom);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            Global_var.dateFrom = DateTime.Today;
            Global_var.dateTo= DateTime.Today.AddDays(1).AddTicks(-1);
            BaseColorChange(btnToday);
        }

        private void btnLast7_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            Global_var.dateTo= DateTime.Today.AddDays(1).AddTicks(-1);
            Global_var.dateFrom = DateTime.Today.AddDays(-7);
            BaseColorChange(btnLast7);
        }

        private void btnLast30_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            Global_var.dateFrom = DateTime.Today.AddDays(-30);
            Global_var.dateTo = DateTime.Today.AddDays(1).AddTicks(-1);
            BaseColorChange(btnLast30);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnCustom.BackColor == Color.PowderBlue)
            {
                Global_var.dateFrom = dtpFrom.Value;
                Global_var.dateTo = dtpTo.Value;    
            }
            ArrayList OrdersComplete = new ArrayList();
            if (Global_var.dateFrom<Global_var.dateTo)
            {
                strSQL = "SELECT * FROM order_list WHERE (CAST(supplydate AS DATE) BETWEEN @From AND @To) AND orderStatus LIKE '%Completed%';";
                SqlConnection con1 = new SqlConnection(Global_var.strDBConnectionString);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(strSQL, con1);
                cmd1.Parameters.AddWithValue("@From",Global_var.dateFrom);
                cmd1.Parameters.AddWithValue("@To",Global_var.dateTo);
                SqlDataReader reader= cmd1.ExecuteReader();
                intTotalRevenue = 0;
                while (reader.Read())
                {
                    intTotalRevenue += (int)reader["ototal"];
                }
                reader.Close();
                strSQL = "SELECT COUNT(*) FROM order_list WHERE (CAST(supplydate AS DATE) BETWEEN @From AND @To) AND orderStatus LIKE '%Completed%';";
                SqlCommand cmd2 = new SqlCommand(strSQL, con1);
                cmd2.Parameters.AddWithValue("@From", Global_var.dateFrom);
                cmd2.Parameters.AddWithValue("@To", Global_var.dateTo);
                int count = (int)cmd2.ExecuteScalar();
                lblTotalOrders.Text = count.ToString();
                con1.Close();
                lblRevenue.Text=intTotalRevenue.ToString();

            }
            else
            {
                MessageBox.Show("Invalid time range.");
            }
            loadChartProduct();
            loadChartRevenue();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers myUsersetting= new frmUsers();
            myUsersetting.ShowDialog();
        }
    }
}
