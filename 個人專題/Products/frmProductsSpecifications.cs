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

namespace 個人專題.Products
{
    public partial class frmProductsSpecifications : frmEditAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;

        public frmProductsSpecifications()
        {
            InitializeComponent();
        }

        private void frmProductsSpecifications_Load(object sender, EventArgs e)
        {
            lblName.Text = Global_var.strProductName;
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
            if (Global_var.intUserPrivilege == 3)
            {
                載入data();
            }
            else
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT p.productsName [Product name],ps.container [Container (oz)],ps.pweight [Product weight],ps.packageDescription [Package description]\r\nFROM products p JOIN specifications ps ON p.pNum = ps.pNum\r\nWHERE p.pNum=@SelectID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SelectID", Global_var.intIDChoose);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvProductSpecification.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }

            if (dgvProductSpecification.Rows.Count > 0)
            {
                dgvProductSpecification.CurrentCell = dgvProductSpecification.Rows[0].Cells[1];
                dgvProductSpecification.Rows[0].Selected = true;
            }
        }

        void 載入data()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT p.productsName [Product name],ps.container [Container (oz)],ps.pweight [Product weight],ps.pprice Price,ps.packageDescription [Package description]\r\nFROM products p JOIN specifications ps ON p.pNum = ps.pNum\r\nWHERE p.pNum=@SelectID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SelectID", Global_var.intIDChoose);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvProductSpecification.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void frmProductsSpecifications_Activated(object sender, EventArgs e)
        {
            if (Global_var.intUserPrivilege == 3)
            {
                載入data();
            }
            else
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT p.productsName [Product name],ps.container [Container (oz)],ps.pweight [Product weight],ps.packageDescription [Package description]\r\nFROM products p JOIN specifications ps ON p.pNum = ps.pNum\r\nWHERE p.pNum=@SelectID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SelectID", Global_var.intIDChoose);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv筆數 = dt.Rows.Count;
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvProductSpecification.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
