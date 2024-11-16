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
using 個人專題.Products;

namespace 個人專題
{
    public partial class frmProducts : frmMainViewAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); 
        int dgv筆數 = 0;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            if(Global_var.intUserPrivilege==3 || Global_var.intUserPrivilege == 2)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }
            cBoxSearch.Items.Add("product name");
            cBoxSearch.Items.Add("category");
            cBoxSearch.Items.Add("seeds stock");
            cBoxSearch.SelectedIndex = 0;

            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
            顯示所有資料();
            if (dgvProducts.Rows.Count > 0)
            {
                dgvProducts.CurrentCell = dgvProducts.Rows[0].Cells[0];
                dgvProducts.Rows[0].Selected = true;
                Global_var.strProductName= dgvProducts.Rows[0].Cells[2].Value.ToString(); ;
            }
            
        }

        private void 顯示所有資料()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT p.pNum [Product ID],pc.categoriesName Category,p.productsName [Product name],p.productsSeedStock [Seed stock],p.produceDays [Estimated Production Period] FROM products p LEFT JOIN products_categories pc ON p.categoriesNum = pc.categoriesNum;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvProducts.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
                Global_var.strProductChangeChoose = "Add";
                frmProductsChangeChoose myProductsChangeChoose = new frmProductsChangeChoose();
                myProductsChangeChoose.ShowDialog();
            
        }
        internal override void btnEdit_Click(object sender, EventArgs e)
        {
            Global_var.strProductChangeChoose = "Edit";
            frmProductsChangeChoose myProductsChangeChoose = new frmProductsChangeChoose();
            myProductsChangeChoose.ShowDialog();
        }

        private void btnViewSpecification_Click(object sender, EventArgs e)
        {
            frmProductsSpecifications myPSpecifications= new frmProductsSpecifications();
            myPSpecifications.ShowDialog();
        }

        void 壓縮搜尋(string strSQL2)
        {
            SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(strSQL2, conn);
            cmd1.Parameters.AddWithValue(@"SearchName", $"%{txtSearchProducts.Text}%");
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader1);
                dgv筆數 = dt.Rows.Count;
                dgvProducts.Font = new Font("微軟正黑體", 12);
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data.");
            }
            reader1.Close();
            conn.Close();
        }

        internal override void btnSearch_Click(object sender, EventArgs e)
        {
            if (cBoxSearch.SelectedIndex == 0)
            {
                string strSQL1 = "SELECT  TOP 100 p.pNum [Product ID],pc.categoriesName Category,p.productsName [Product name],p.productsSeedStock [Seed stock],p.produceDays [Estimated Production Period] FROM products p LEFT JOIN products_categories pc ON p.categoriesNum = pc.categoriesNum WHERE p.productsName  LIKE  @SearchName;";
                壓縮搜尋(strSQL1);
            }
            else if (cBoxSearch.SelectedIndex == 1)
            {
                string strSQL1 = "SELECT  TOP 100 p.pNum [Product ID],pc.categoriesName Category,p.productsName [Product name],p.productsSeedStock [Seed stock],p.produceDays [Estimated Production Period] FROM products p LEFT JOIN products_categories pc ON p.categoriesNum = pc.categoriesNum WHERE pc.categoriesName  LIKE  @SearchName;";
                壓縮搜尋(strSQL1);
            }
            else if(cBoxSearch.SelectedIndex == 2)
            {
                string strSQL1 = "SELECT  TOP 100 p.pNum [Product ID],pc.categoriesName Category,p.productsName [Product name],p.productsSeedStock [Seed stock],p.produceDays [Estimated Production Period] FROM products p LEFT JOIN products_categories pc ON p.categoriesNum = pc.categoriesNum WHERE p.productsSeedStock=@SearchName;";
                SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
                cmd1.Parameters.AddWithValue(@"SearchName", txtSearchProducts.Text);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader1);
                    dgv筆數 = dt.Rows.Count;
                    dgvProducts.Font = new Font("微軟正黑體", 12);
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvProducts.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data.");
                }
                reader1.Close();
                conn.Close();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                string strID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                int selectId = 0;
                Int32.TryParse(strID, out selectId);
                Global_var.intIDChoose = selectId;
                Global_var.strProductName = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            }
            else
            {
                Global_var.intIDChoose = -1;
                Global_var.strProductName = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            顯示所有資料();
        }
    }
}
