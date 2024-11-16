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
using 個人專題.Inherit;

namespace 個人專題
{
    public partial class frmUsers : frmOrderlistAdd
    {
        string strSelectUser = "";
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value = DateTime.Now;
            cBoxPrivilege.Items.Add(0); //visitors
            cBoxPrivilege.Items.Add(1); //staffs    
            cBoxPrivilege.Items.Add(2); //manager
            cBoxPrivilege.Items.Add(3); //boss

            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            try
            {
                con.Open();
                string strSQL = "SELECT * FROM user_login;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                cBoxUserName.Items.Clear();
                while (reader.Read())
                {
                    cBoxUserName.Items.Add(reader["username"].ToString().Trim());
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            strSelectUser=cBoxUserName.SelectedItem.ToString();
            loadData();
        }

        private void loadData()
        {
            SqlConnection con1=new SqlConnection(Global_var.strDBConnectionString);
            con1.Open();
            string strSQL1 = "SELECT * FROM user_login WHERE username=@SelectUser;";
            SqlCommand cmd1= new SqlCommand(strSQL1 , con1);
            cmd1.Parameters.AddWithValue("@SelectUser", strSelectUser);
            SqlDataReader reader1=cmd1.ExecuteReader();
            if (reader1.Read()) 
            {
                txtPassword.Text = reader1["upass"].ToString();
                txtRealName.Text = reader1["uRealName"].ToString();
                txtPhone.Text = reader1["uphone"].ToString();
                txtUID.Text = reader1["userID"].ToString();
                dtpBirthday.Value= (DateTime)reader1["uBirth"];
                cBoxPrivilege.SelectedItem = reader1["uPrivilege"];

                str修改後的圖檔名稱 = reader1["uphoto"].ToString();
                string str完整圖檔路徑 = $"{Global_var.image_dirLogin}\\{str修改後的圖檔名稱}";
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                pBoxPhoto.Image = Image.FromStream(fs);
                fs.Close();
                pBoxPhoto.Tag = str完整圖檔路徑;
            }
            else
            {
                MessageBox.Show("Error");
            }
            reader1.Close();
            con1.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        void 選取商品圖片()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(PNG)|*.png";
            DialogResult R = ofd.ShowDialog();
            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pBoxPhoto.Image = Image.FromStream(fs);
                fs.Close();
                pBoxPhoto.Tag = ofd.FileName;
                //取得目前圖檔的副檔名
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower(); 
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
            }
        }

        private bool IsPhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$"); 
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string strNewPhone = txtPhone.Text;
            if ((txtRealName.Text!="")&&(txtPassword.Text != "") && (txtPhone.Text != "") && (dtpBirthday.Value != default) && (dtpBirthday.Value != DateTime.Now) && (pBoxPhoto.Image != null))
            {
                if (IsPhoneValid(strNewPhone))
                {
                    SqlConnection con2 = new SqlConnection(Global_var.strDBConnectionString);
                    con2.Open();
                    string strSQL2 = "UPDATE user_login SET upass=@NewPass,uRealName=@NewRName,uphone=@NewPhone,uphoto=@NewPhoto,uBirth=@NewBirth, uPrivilege=@NewPre WHERE userID = @SearchID;";
                    SqlCommand cmd2= new SqlCommand(strSQL2, con2);
                    cmd2.Parameters.AddWithValue("@NewPass",txtPassword.Text);
                    cmd2.Parameters.AddWithValue("@NewRName", txtRealName.Text);
                    cmd2.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd2.Parameters.AddWithValue("@NewPhoto", str修改後的圖檔名稱);
                    cmd2.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                    string strPre=cBoxPrivilege.SelectedItem.ToString();
                    cmd2.Parameters.AddWithValue("@NewPre", strPre);
                    cmd2.Parameters.AddWithValue("@SearchID",txtUID.Text);
                    int rows = cmd2.ExecuteNonQuery();
                    con2.Close();
                    MessageBox.Show($"Update successfully. Rows changed:{rows}");
                }
                else
                {
                    MessageBox.Show("Wrong phone number. \nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incomplete data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure you want to delete this user ?", "", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                if (Global_var.intIDChoose > 0)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "DELETE FROM user_login WHERE userID=@Deleted;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Deleted", txtUID.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    System.IO.File.Delete(pBoxPhoto.Tag.ToString());
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
