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
using 個人專題.Inherit;

namespace 個人專題
{
    public partial class frmPrductsAdd :frmEditAdd
    {
        internal event Action DataChanged;
        int dgv筆數 = 0;
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;

        public frmPrductsAdd()
        {
            InitializeComponent();
        }


        private void frmPrductsAdd_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            try
            {
                con.Open();
                string strSQL = "SELECT * FROM products_categories;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                cBoxProductCategory.Items.Clear();
                while (reader.Read())
                {
                    cBoxProductCategory.Items.Add(reader["categoriesName"].ToString().Trim());
                    string strCChoose = reader["categoriesNum"].ToString().Trim();
                    int CChoose = 0;
                    Int32.TryParse(strCChoose, out CChoose);
                    string strCategoryChoose= reader["categoriesName"].ToString().Trim();
                    
                }
                
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

            
            if (Global_var.strProductChangeChoose == "Add")
            {
                lblName.Text = "New product";
                btnOK.Text = "Add";
                btnDeleteData.Visible = false;  
            }
            else
            {
                lblName.Text = Global_var.strProductName;
                btnOK.Text = "Save";
                string strSQL2 = "SELECT p.productsName,pc.categoriesName,p.productsSeedStock,p.produceDays,p.productsPicture \r\nFROM products p LEFT JOIN products_categories pc ON p.categoriesNum = pc.categoriesNum\r\nWHERE p.pNum=@SelectNum";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@SelectNum", Global_var.intIDChoose);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    txtProductName.Text = reader2["productsName"].ToString();
                    txtSeedStock.Text = reader2["productsSeedStock"].ToString();
                    txtDaysRequire.Text = reader2["produceDays"].ToString();
                    string strCategory = reader2["categoriesName"].ToString();
                    if (cBoxProductCategory.Items.Contains(strCategory))
                    {
                        cBoxProductCategory.SelectedItem = strCategory;
                    }
                    str修改後的圖檔名稱 = reader2["productsPicture"].ToString();
                    string str完整圖檔路徑 = $"{Global_var.image_dir}\\{str修改後的圖檔名稱}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                    pictureBoxProduct.Image = Image.FromStream(fs);
                    fs.Close();
                    pictureBoxProduct.Tag = str完整圖檔路徑;
                }
                reader2.Close();
                con.Close();
            }
        }

        void 選取商品圖片()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(PNG)|*.png"; 
            DialogResult R = ofd.ShowDialog();
            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pictureBoxProduct.Image = Image.FromStream(fs);
                fs.Close();
                pictureBoxProduct.Tag = ofd.FileName;
                //取得目前圖檔的副檔名
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower(); //全部小寫避免混亂
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        

        private bool IsNumValid1(string NumInput)
        {
            if (Int32.TryParse(NumInput, out int result))
            {
                return result >= 0;
            }
            else
            {
                return false;
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string strSeed = txtSeedStock.Text.Trim();
            string strDaysRequire =txtDaysRequire.Text.Trim();
            
            if ((txtProductName.Text != "") && (txtSeedStock.Text != "") &&(cBoxProductCategory.SelectedIndex >= 0) && (pictureBoxProduct.Image != null))
            {
                if (!IsNumValid1(strSeed))
                {
                    MessageBox.Show("Invalid seed stock input.");
                }
                else if (!IsNumValid1(strDaysRequire))
                {
                    MessageBox.Show("Invalid days requried for production input.");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    string CategoryC = cBoxProductCategory.SelectedItem.ToString().Trim();
                    string strSQLC = "SELECT * FROM products_categories WHERE categoriesName=@CNameC";
                    SqlCommand cmd3 = new SqlCommand(strSQLC, con);
                    cmd3.Parameters.AddWithValue("@CNameC", CategoryC);
                    SqlDataReader read = cmd3.ExecuteReader();
                    int intCOutput = 0;
                    if (read.Read())
                    {
                        string strCChooseOutput = read["categoriesNum"].ToString().Trim();
                        Int32.TryParse(strCChooseOutput, out intCOutput);
                    }
                    read.Close();
                    string strSQL = "";
                    if (Global_var.strProductChangeChoose == "Add")
                    {
                        strSQL = "INSERT INTO products VALUES (@NewCategory,@NewPName,@NewSeed,@NewPimage,@NewPDay)";
                    }
                    else
                    {
                        strSQL = "UPDATE products\r\nSET categoriesNum=@NewCategory,productsName=@NewPName,productsSeedStock=@NewSeed,productsPicture=@NewPimage,produceDays=@NewPDay WHERE pNum = @SearchID;";
                    }

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewCategory", intCOutput);
                    cmd.Parameters.AddWithValue("@NewPName", txtProductName.Text);
                    int intSeedStock = 0;
                    Int32.TryParse(txtSeedStock.Text, out intSeedStock);
                    cmd.Parameters.AddWithValue("@NewSeed", intSeedStock);
                    cmd.Parameters.AddWithValue("@NewPimage", str修改後的圖檔名稱);
                    int intPDays = 0;
                    Int32.TryParse(txtDaysRequire.Text, out intPDays);
                    cmd.Parameters.AddWithValue("@NewPDay", intPDays);
                    cmd.Parameters.AddWithValue("@SearchID", Global_var.intIDChoose);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (is修改圖檔)
                    {
                        string 完整圖檔路徑 = $"{Global_var.image_dir}\\{str修改後的圖檔名稱}";
                        pictureBoxProduct.Image.Save(完整圖檔路徑);
                        is修改圖檔 = false;
                    }
                    MessageBox.Show($"Save successfully.Rows change:{rows}");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incomplete data.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCloseWindow_Click_1(object sender, EventArgs e)
        {
            frmProducts myProducts = new frmProducts();
            myProducts.Refresh();
        }
        void 清空欄位()
        {
            txtProductName.Clear();
            txtSeedStock.Clear();
            txtDaysRequire.Clear();
            cBoxProductCategory.SelectedIndex = -1;
            pictureBoxProduct.Image = null;
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure to delete this product ?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intIDChoose > 0)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "DELETE FROM products WHERE pNum=@Deleted;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Deleted", Global_var.intIDChoose);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    System.IO.File.Delete(pictureBoxProduct.Tag.ToString());
                    MessageBox.Show($"Deleted successfully. \n {rows} rows of data have changed.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error. No data is selected.");
                }
            }
        }
    }
}
