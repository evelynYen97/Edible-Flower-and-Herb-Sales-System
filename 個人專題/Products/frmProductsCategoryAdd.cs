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

namespace 個人專題.Products
{
    public partial class frmProductsCategoryAdd : frmEditAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;

        public frmProductsCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmProductsCategoryAdd_Load(object sender, EventArgs e)
        {
            lblName.Text = "Categories";
            if (Global_var.strProductChangeChoose == "Add")
            {
                btnOK.Text= "Add";
                dgvCategories.ReadOnly = true;
                dgvCategories.Enabled=false;
            }
            else
            {
                btnOK.Text = "Save";
                btnCancel.Text = "Delete";
                dgvCategories.ReadOnly = false;
                dgvCategories.Enabled = true;
            }
            載入data();
        }

         void 載入data()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT categoriesNum [Categories ID],categoriesName [Categories Name]\r\nFROM products_categories";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvCategories.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private bool IsCategoryValid (string category)
        {
            if (category != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string CategoryInput = txtCategoryName.Text;
            if (IsCategoryValid(CategoryInput))
            {
                if (Global_var.strProductChangeChoose == "Add")
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "INSERT INTO products_categories VALUES (@NewCategory) ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewCategory", txtCategoryName.Text);
                    int rows =cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                    MessageBox.Show($"Added successfully.");
                    載入data();
                }
                else
                {
                    int intCategoryID = Global_var.intIDChoose;
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    string strSQL = "UPDATE products_categories SET categoriesName=@NewCategory WHERE categoriesNum=@CategoryId;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewCategory", txtCategoryName.Text);
                    cmd.Parameters.AddWithValue("@CategoryId", txtCategoryID.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                    MessageBox.Show($"Update successfully.{rows}rows of data have changed.");
                    載入data();
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (Global_var.strProductChangeChoose == "Add")
            {
                txtCategoryName.Clear();
            }
            else
            {
                DialogResult R = MessageBox.Show("Are you sure to delete this selected data ?", "", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "DELETE FROM products_categories WHERE categoriesNum=@CategoryId;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@CategoryId", ChooseCID);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Deleted successfully. \n {rows} rows of data have changed.");
                    載入data();
                }
            }
            
        }
        private int ChooseCID = 1;

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                txtCategoryID.Text = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                Int32.TryParse(txtCategoryID.Text, out ChooseCID);
            }
        }
    }
}
