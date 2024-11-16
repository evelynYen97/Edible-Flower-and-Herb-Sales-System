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
using System.Windows.Controls;
using 個人專題.Inherit;

namespace 個人專題.Products
{
    public partial class frmProductsSpecificationsAdd : frmEditAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;
        public frmProductsSpecificationsAdd()
        {
            InitializeComponent();
        }

        private void frmProductsSpecificationsAdd_Load(object sender, EventArgs e)
        {
            lblName.Text = Global_var.strProductName;
            btnOK.Text = "Add";
            lblName.Text = "New Specification";
            txtProductName.Text= Global_var.strProductName;
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
            if ((txtPrice.Text != "") && (txtContainer.Text != "") && (txtProductWeight.Text != ""))
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
                if (IsPWeightValid(WInput) && IsPWeightValid(WContainer) && IsPWeightValid(WPrice))
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
                        string strSQL2 = "INSERT INTO specifications VALUES (@PContainer,@PWeight,@PDesc,@PPrice,@PID);";
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
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Successfully added. Rows changed:{rows}");
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Incomplete data. Please try again.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtProductWeight.Clear();
            txtDesc.Clear();
            txtContainer.Clear();
            txtPrice.Clear();
        }
    }
}
