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

namespace 個人專題.Staffs
{
    public partial class frmStaffsAdd :frmEditAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;
        internal event Action DataUpdated;
        string strSexChoose1 = "";
        public frmStaffsAdd()
        {
            InitializeComponent();
        }

        private void frmStaffsAdd_Load(object sender, EventArgs e)
        {
            cBoxSex.Items.Add("male");
            cBoxSex.Items.Add("female");
            cBoxSex.SelectedIndex = 0;
            cBoxJobTitle.Items.Add("Clerk");
            cBoxJobTitle.Items.Add("Manager");
            cBoxJobTitle.Items.Add("Driver");
            cBoxJobTitle.Items.Add("President");
            cBoxJobTitle.SelectedIndex = 0;
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
            if (Global_var.strProductChangeChoose == "Edit")
            {
                if (Global_var.intIDChoose >= 0)
                {
                    資料填充();
                    btnOK.Text = "Save";
                    lblName.Text = "Staff";
                }
                else
                {
                    MessageBox.Show("No Data");
                    this.Close();
                }
            }
        }

        private void 資料填充()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT  * FROM staff WHERE snum=@SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", Global_var.intIDChoose); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                txtStafftName.Text = (string)reader["sname"];
                dtpBitday.Value = (DateTime)reader["sbirth"];
                int intSexChoose = -1;
                Global_var.strSexChoose= (string)reader["ssex"];
                strSexChoose1 = Global_var.strSexChoose.Trim();
                if (strSexChoose1=="male")
                {

                    intSexChoose = 0;
                }
                else if (strSexChoose1== "female")
                {
                    intSexChoose = 1;
                }
                cBoxSex.SelectedIndex = intSexChoose;
                txtPhone.Text = (string)reader["sphone"];
                txtEmail.Text= (string)reader["sEmail"];
                dtpFromDate.Value= (DateTime)reader["shiredate"];
                txtAddressC.Text= (string)reader["saddressContact"];
                txtAddressD.Text = (string)reader["saddressDomicile"];
                txtSal.Text= reader["ssal"].ToString();
                int intJobChoose = 0;
                Global_var.strSexChoose = (string)reader["stitle"];
                string strJobChoose = Global_var.strJobChoose.Trim();
                switch (strJobChoose)
                {
                    case "Clerk":
                        intJobChoose = 0;
                        break;
                    case "Manager":
                        intJobChoose = 1;
                        break;
                    case "Driver":
                        intJobChoose = 2;
                        break;
                    case "President":
                        intJobChoose = 3;
                        break;
                    default:
                        break;
                }
                cBoxJobTitle.SelectedIndex=intJobChoose;
                txtResponsible.Text= (string)reader["sInChargeProject"];
            }
            else
            {
                MessageBox.Show("No Data");
            }
            reader.Close();
            con.Close();
        }

        private bool IsPhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$"); // ^從字串第一個字開始匹配 \d表示0-9任一數字 {10}表示前面的元素必須出現10次 $字串結束
        }

        private bool IsSalValid(string sal)
        {
            if (decimal.TryParse(sal, out decimal result))
            {
                return result >= 27470;
            }
            else
            {
                return false;
            }
        }

        internal override void btnOK_Click(object sender, EventArgs e)
        {
            string phoneInput = txtPhone.Text.Trim();
            string salaryInput = txtSal.Text.Trim();

            if (IsPhoneValid(phoneInput) && IsSalValid(salaryInput)) 
            {
                if (Global_var.strProductChangeChoose == "Add")
                {
                    if ((txtStafftName.Text != "") && (txtPhone.Text != "") && (txtSal.Text != "") && (txtEmail.Text != "") && (txtAddressD.Text != "") && (dtpBitday.Value != DateTime.Now) && (cBoxSex.SelectedIndex != -1))
                    {
                        SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                        string strSQL = "INSERT INTO staff \r\nVALUES (@NewName,@NewBirth,@NewSex,@NewPhone,@NewEmail,@NewHire,@NewFire,@NewAddressC,@NewAddressD,@NewSal,@NewTitle,@NewInCharge);";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txtStafftName.Text);
                        cmd.Parameters.AddWithValue("@NewBirth", dtpBitday.Value);
                        string str性別 = cBoxSex.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@NewSex", $"{str性別}");
                        cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NewHire", dtpFromDate.Value);
                        //string strNotFireYet = "";
                        cmd.Parameters.AddWithValue("@NewFire", $"");
                        cmd.Parameters.AddWithValue("@NewAddressC", txtAddressC.Text);
                        cmd.Parameters.AddWithValue("@NewAddressD", txtAddressD.Text);
                        cmd.Parameters.AddWithValue("@NewSal", txtSal.Text);
                        string strJobTitle = cBoxJobTitle.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@NewTitle", $"{strJobTitle}");
                        cmd.Parameters.AddWithValue("@NewInCharge", txtResponsible.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Close();
                        MessageBox.Show($"Added successfully");
                        DataUpdated?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("The field information is not complete.");
                    }
                }
                else
                {
                    int intID = Global_var.intIDChoose;
                    if ((intID > 0) && (txtStafftName.Text != "") && (txtPhone.Text != "") && (txtSal.Text != "") && (txtEmail.Text != "") && (txtAddressD.Text != "") && (dtpBitday.Value != DateTime.Now) && (cBoxSex.SelectedIndex != -1) && (cBoxJobTitle.SelectedIndex != -1)) //
                    {
                        SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                        con.Open();
                        string strSQL = "UPDATE staff SET sname=@NewName,sbirth=@NewBirth,ssex=@NewSex,sphone=@NewPhone,sEmail=@NewEmail,sresignation=@NewFire,saddressContact=@NewAddressC,saddressDomicile=@NewAddressD,ssal=@NewSal,stitle=@NewTitle,sInChargeProject=@NewInCharge WHERE snum=@SearchId;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@NewName", txtStafftName.Text);
                        cmd.Parameters.AddWithValue("@NewBirth", dtpBitday.Value);
                        string str性別 = cBoxSex.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@NewSex", $"{str性別}");
                        cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NewHire", dtpFromDate.Value);
                        DateTime dateValue = new DateTime(1900, 1, 1);
                        cmd.Parameters.AddWithValue("@NewFire", dateValue);
                        cmd.Parameters.AddWithValue("@NewAddressC", txtAddressC.Text);
                        cmd.Parameters.AddWithValue("@NewAddressD", txtAddressD.Text);
                        cmd.Parameters.AddWithValue("@NewSal", txtSal.Text);
                        string strJobTitle = cBoxJobTitle.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@NewTitle", $"{strJobTitle}");
                        cmd.Parameters.AddWithValue("@NewInCharge", txtResponsible.Text);
                        cmd.Parameters.AddWithValue("@SearchId", intID);

                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"Update successfully. Rows changed:{rows}");
                        DataUpdated?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("The field information is not complete.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong input.\nPhone number should be ten-digit number and salary should be numbers greater than 27,470. \nPlease try again.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        internal override void btnCancel_Click(object sender, EventArgs e)
        {
            if (Global_var.strProductChangeChoose == "Add")
            {
                txtStafftName.Clear();
                dtpBitday.Value = DateTime.Today;
                cBoxSex.SelectedIndex = -1;
                txtPhone.Clear();
                txtSal.Clear();
                dtpFromDate.Value = DateTime.Today;
                txtEmail.Clear();
                txtAddressC.Clear();
                txtAddressD.Clear();
                cBoxJobTitle.SelectedIndex = -1;
                txtResponsible.Clear();
            }
            else
            {
                資料填充();
            }
        }
    }
}
