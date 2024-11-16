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
using 個人專題.Login;

namespace 個人專題
{
    public partial class frmLoginForgotPW : Form
    {
        string strPhoneCheck = "";
        DateTime dateCheck= DateTime.Now.Date;
        public frmLoginForgotPW()
        {
            InitializeComponent();
        }

        private void frmLoginForgotPW_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value = DateTime.Now.Date;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime dateDefault = DateTime.Now.Date;
            if ((txtRealName.Text != "") && (txtPhone.Text != "") && (dtpBirthday.Value != dateDefault))
            {
                string strSQL = "SELECT *\r\nFROM user_login\r\nWhere uRealName=@ULogin";
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ULogin", txtRealName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()==true)
                {
                    strPhoneCheck= reader["uphone"].ToString().Trim();
                    dateCheck= (DateTime)reader["uBirth"];
                    Global_var.intUID= (int)reader["userID"];
                    if ((strPhoneCheck == txtPhone.Text.Trim()) && (dateCheck == dtpBirthday.Value))
                    {
                        MessageBox.Show("The user does exist. Please change your password.");
                        this.Close();
                        frmChangePassword myChangePass= new frmChangePassword();
                        myChangePass.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong phone number or bithday.");
                    }
                }
                else
                {
                    MessageBox.Show("This user could not be found.");
                }
            }
            else
            {
                MessageBox.Show("The field information is not complete.");
            }
        }
    }
}
