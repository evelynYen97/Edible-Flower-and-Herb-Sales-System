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

namespace 個人專題
{
    public partial class frmLoginRegister : frmOrderlistAdd
    {
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;

        public frmLoginRegister()
        {
            InitializeComponent();
        }

        private void frmLoginRegister_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value=DateTime.Now.Date;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ChoosePhoto();
        }
        void ChoosePhoto()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(PNG)|*.png";
            DialogResult R = ofd.ShowDialog();
            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pictureBoxUser.Image = Image.FromStream(fs);
                fs.Close();
                pictureBoxUser.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower(); 
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        private bool IsPhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$"); 
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            DateTime dateDefault= DateTime.Now.Date;
            string phoneInput = txtPhoneNum.Text.Trim();
            if((txtUserName.Text != "") && (txtPassword.Text != "") && (txtRealName.Text != "") && (txtPhoneNum.Text != "") && (pictureBoxUser.Image != null) && (dtpBirthday.Value != dateDefault) )
            {
                if (IsPhoneValid(phoneInput) && (dtpBirthday.Value < dateDefault))
                {
                    string strSQL = "INSERT INTO user_login VALUES (@NewUserName,@NewPass,@NewReal,@NewPhone,@NewPhoto,@NewBirth,@NewLogin)";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewUserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@NewPass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@NewReal", txtRealName.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhoneNum.Text);
                    cmd.Parameters.AddWithValue("@NewPhoto", str修改後的圖檔名稱);
                    cmd.Parameters.AddWithValue("@NewBirth", dtpBirthday.Value);
                    cmd.Parameters.AddWithValue("@NewLogin", 0);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (is修改圖檔)
                    {
                        string 完整圖檔路徑 = $"{Global_var.image_dirLogin}\\{str修改後的圖檔名稱}";
                        pictureBoxUser.Image.Save(完整圖檔路徑);
                        is修改圖檔 = false;
                    }
                    MessageBox.Show($"Save successfully.Rows change:{rows}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid phone number or birthday.");
                }
            }
            else
            {
                MessageBox.Show("The field information is not complete.");
            }
            
        }

        private void btnPasswordVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = default;
        }

        private void btnPasswordVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
