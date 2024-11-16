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
    public partial class frmLogin : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void InitialInterface_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool formMove = false;
        private Point formPoint; //記錄窗體位置
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point(e.X, e.Y);
            formMove = true;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                Point WindowPos = new Point(mousePos.X - formPoint.X, mousePos.Y - formPoint.Y);
                this.Location = WindowPos; //設置窗口坐標
            }
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                checkUsername.Checked = true;   
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                checkPassword.Checked = true;
            }
        }

        private void btnPasswordVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar =default;
        }

        private void btnPasswordVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strPassCheck = "";
            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                string strSQL = "SELECT *\r\nFROM user_login\r\nWhere username=@ULogin";
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ULogin", txtUserName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    strPassCheck = reader["upass"].ToString().Trim();
                    Global_var.intUID = (int)reader["userID"];
                    Global_var.intUserPrivilege = (int)reader["uPrivilege"];
                    Global_var.strUserName = reader["username"].ToString().Trim();
                    if ((strPassCheck == txtPassword.Text.Trim()))
                    {
                        frmMain myfrmMain1 = new frmMain();
                        this.Hide();
                        myfrmMain1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.");
                    }
                }
                else
                {
                    MessageBox.Show("This user could not be found.");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the blank.");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            frmLoginRegister myLoginRegister = new frmLoginRegister();
            myLoginRegister.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            frmLoginForgotPW myLoginForgotPW = new frmLoginForgotPW();
            myLoginForgotPW.ShowDialog();
        }
    }
}
