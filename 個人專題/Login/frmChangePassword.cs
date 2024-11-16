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

namespace 個人專題.Login
{
    public partial class frmChangePassword : frmOrderlistAdd
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if((txtPass1.Text!="")&& (txtPass2.Text != ""))
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    string strSQL = "UPDATE user_login SET upass=@NewPass WHERE userID=@UID;";
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewPass", txtPass1.Text);
                    cmd.Parameters.AddWithValue("@UID", Global_var.intUID);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Update successfully. Rows changed:{rows}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The two inputs are inconsistent.");
                }
            }
            else
            {
                MessageBox.Show("Please set your passwords.");
            }
        }
    }
}
