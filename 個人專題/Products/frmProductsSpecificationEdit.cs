using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 個人專題.Inherit;

namespace 個人專題.Products
{
    public partial class frmProductsSpecificationEdit : frmEditAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;
        int intSIDSelected = 0;

        public frmProductsSpecificationEdit()
        {
            InitializeComponent();
        }

        private void frmProductsSpecificationEdit_Load(object sender, EventArgs e)
        {
            lblName.Text = "Edit Products Specification";
            載入data();
        }

        void 載入data()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT p.productsName [Product name],ps.specificationsNum [Specifications ID],ps.container [Container (oz)],ps.pweight [Product weight],ps.pprice Price,ps.packageDescription [Package description]\r\nFROM products p JOIN specifications ps ON p.pNum = ps.pNum\r\nWHERE p.pNum=@SelectID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SelectID", Global_var.intIDChoose);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvPSpecificEdit.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgvPSpecificEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                txtProductName.Text = dgvPSpecificEdit.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtContainer.Text = dgvPSpecificEdit.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvPSpecificEdit.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtProductWeight.Text = dgvPSpecificEdit.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDesc.Text = dgvPSpecificEdit.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSID.Text= dgvPSpecificEdit.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            Int32.TryParse(txtSID.Text,out intSIDSelected);
        }

        private bool IsPWeightValid(string Input)
        {
            if (decimal.TryParse(Input, out decimal result))
            {
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        private bool IsContainerValid(string CInput)
        {
            if (Int32.TryParse(CInput, out int result))
            {
                return result > 0;
            }
            else
            {
                return false;
            }
        }
       

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string WInput = txtProductWeight.Text.Trim();
            string WContainer = txtContainer.Text.Trim();
            string WPrice = txtPrice.Text.Trim();
            if((txtPrice.Text != "") && (txtContainer.Text != "") && (txtProductWeight.Text != ""))
            {
                if (IsPWeightValid(WInput) == false)
                {
                    MessageBox.Show("Invalid Product Weight.");
                }
                if (IsContainerValid(WContainer) == false)
                {
                    MessageBox.Show("Invalid Product Container.");
                }
                if (IsPWeightValid(WPrice) == false)
                {
                    MessageBox.Show("Invalid Price.");
                }
                if(IsPWeightValid(WInput)&& IsPWeightValid(WContainer) && IsPWeightValid(WPrice))
                {
                    string strSQLq = "SELECT COUNT(*) \r\nFROM products p JOIN specifications ps ON p.pNum = ps.pNum \r\nWHERE p.productsName = @PName AND ps.container = @PContainer AND ps.pweight=@PWeight AND ps.pprice =@PPrice;";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQLq, con);
                    cmd.Parameters.AddWithValue("@PName", txtProductName.Text);
                    int intContainer = 0;
                    Int32.TryParse(txtContainer.Text, out intContainer);
                    cmd.Parameters.AddWithValue("@PContainer", intContainer);
                    Double PWeight = 0.00;
                    Double.TryParse(txtProductWeight.Text, out PWeight);
                    cmd.Parameters.AddWithValue("@PWeight", PWeight);
                    Double PPrice = 0.00;
                    Double.TryParse(txtPrice.Text, out PPrice);
                    cmd.Parameters.AddWithValue("@PPrice", PPrice);
                    
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Data already exists.");
                    }
                    else
                    {
                        string strSQL2 = "UPDATE specifications SET container=@PContainer,pweight=@PWeight,packageDescription=@PDesc,pprice=@PPrice,pNum=@PID WHERE specificationsNum=@SID;";
                        cmd = new SqlCommand(strSQL2, con);
                        int intContainer2 = 0;
                        Int32.TryParse(txtContainer.Text, out intContainer2);
                        cmd.Parameters.AddWithValue("@PContainer", intContainer2);
                        Double PWeight2 = 0.00;
                        Double.TryParse(txtProductWeight.Text, out PWeight2);
                        cmd.Parameters.AddWithValue("@PWeight", PWeight2);
                        Double PPrice2 = 0.00;
                        Double.TryParse(txtPrice.Text, out PPrice2);
                        cmd.Parameters.AddWithValue("@PPrice", PPrice2);
                        cmd.Parameters.AddWithValue("@PDesc", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@PID", Global_var.intIDChoose);
                        int intSID = 0;
                        Int32.TryParse(txtSID.Text, out intSID);
                        cmd.Parameters.AddWithValue("@SID", intSID);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Update successfully. Rows changed:{rows}");
                        載入data();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Incomplete data. Please try again.");
            }

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure to delete this data ?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intIDChoose > 0)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "DELETE FROM specifications WHERE specificationsNum=@SID;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SID", intSIDSelected);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Deleted successfully. \n {rows} rows of data have changed.");
                    載入data();
                }
                else
                {
                    MessageBox.Show("Error. No data is selected.");
                }
            }
        }
    }
}
