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
using 個人專題.Inherit;
using 個人專題.Products;
using 個人專題.Staffs;

namespace 個人專題
{
    public partial class frmStaffs : frmMainViewAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();  
        int dgv筆數 = 0;

        public frmStaffs()
        {
            InitializeComponent();
        }

        private void frmStaffs_Load(object sender, EventArgs e)
        {
            cBoxSearch.Items.Add("staff name");
            cBoxSearch.Items.Add("staff birthday");
            cBoxSearch.Items.Add("phone");
            cBoxSearch.Items.Add("E-mail");
            cBoxSearch.Items.Add("In Charge Project");
            cBoxSearch.Items.Add("All");
            cBoxSearch.SelectedIndex = 0;
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
            顯示所有資料();
            if (dgvStaffs.Rows.Count > 0)
            {
                dgvStaffs.CurrentCell = dgvStaffs.Rows[0].Cells[0]; 
                dgvStaffs.Rows[0].Selected = true;
            }
            if (Global_var.intUserPrivilege == 3)
            {
                btnFire.Visible = true;
            }
            else
            {
                btnFire.Visible = false;
            }
        }

        private void 顯示所有資料()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                dgvStaffs.Font= new Font("微軟正黑體", 12);
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvStaffs.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }



        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Global_var.strProductChangeChoose = "Add";
            frmStaffsAdd myStaffsAdd= new frmStaffsAdd();
            myStaffsAdd.DataUpdated += 顯示所有資料;
            myStaffsAdd.ShowDialog();
        }

        internal override void btnEdit_Click(object sender, EventArgs e)
        {
            Global_var.strProductChangeChoose = "Edit";
            frmStaffsAdd myStaffsAdd = new frmStaffsAdd();
            myStaffsAdd.DataUpdated += 顯示所有資料;
            myStaffsAdd.ShowDialog();
        }

        void 壓縮搜尋(string strSQL2)
        {
            SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(strSQL2, conn);
            cmd1.Parameters.AddWithValue(@"SearchName", $"%{txtSearchProducts.Text}%");
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader1);
                dgv筆數 = dt.Rows.Count;
                dgvStaffs.Font = new Font("微軟正黑體", 12);
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvStaffs.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data.");
            }
            reader1.Close();
            conn.Close();
        }
        internal override void btnSearch_Click(object sender, EventArgs e)
        {
            if (cBoxSearch.SelectedIndex == 0)
            {
                string strSQL1 = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff WHERE sname  LIKE  @SearchName;";
                壓縮搜尋(strSQL1);
            }
            else if (cBoxSearch.SelectedIndex == 1)
            {
                SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
                conn.Open();
                string strSQL1 = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff WHERE sbirth=@SearchName;";
                SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
                cmd1.Parameters.AddWithValue(@"SearchName", dateTimePickerDate.Value);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader1);
                    dgv筆數 = dt.Rows.Count;
                    dgvStaffs.Font = new Font("微軟正黑體", 12);
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvStaffs.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data.");
                }
                reader1.Close();
                conn.Close();
            }
            else if (cBoxSearch.SelectedIndex == 2)
            {
                SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
                conn.Open();
                string strSQL1 = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff WHERE sphone = @SearchName;";
                SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
                cmd1.Parameters.AddWithValue(@"SearchName", txtSearchProducts.Text);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader1);
                    dgv筆數 = dt.Rows.Count;
                    dgvStaffs.Font = new Font("微軟正黑體", 12);
                    Console.WriteLine($"DGV筆數：{dgv筆數}");
                    dgvStaffs.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data.");
                }
                reader1.Close();
                conn.Close();
            }
            else if (cBoxSearch.SelectedIndex == 3)
            {
                string strSQL1 = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff WHERE sEmail LIKE @SearchName;";
                壓縮搜尋(strSQL1);
            }
            else if (cBoxSearch.SelectedIndex == 4)
            {
                string strSQL1 = "SELECT snum  [Staff ID],sname  [Staff Name],sbirth Birthday,ssex  [Biological Sex],sphone Phone,sEmail Email,shiredate  [Hire Date],sresignation [Fire Date(default：1900/01/01)],saddressContact  [Contact Address],saddressDomicile  [Domicile Address],ssal Salary, stitle  [Job Title], sInChargeProject  [Responsible project] FROM staff WHERE sInChargeProject  LIKE  @SearchName;";
                壓縮搜尋(strSQL1);
            }
            else if (cBoxSearch.SelectedIndex == 5)
            {
                顯示所有資料();
            }

        }

        private void dgvStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < dgv筆數))
            {
                string strID = dgvStaffs.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                int selectId = 0;
                Int32.TryParse(strID, out selectId);
                Global_var.intIDChoose= selectId;
                Global_var.strSexChoose= dgvStaffs.Rows[e.RowIndex].Cells[3].Value.ToString();
                Global_var.strJobChoose = dgvStaffs.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            else
            {
                Global_var.intIDChoose = -1;
                Global_var.strSexChoose = "";
                Global_var.strJobChoose = "";
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (Global_var.intIDChoose != -1)
            {
                frmFire myFire = new frmFire();
                myFire.Updated += 顯示所有資料;
                myFire.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Staff ");
            }
        }

        private void cBoxSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cBoxSearch.SelectedIndex == 1)
            {
                dateTimePickerDate.Enabled = true;
                txtSearchProducts.Enabled = false;
            }
            else if (cBoxSearch.SelectedIndex == 5)
            {
                dateTimePickerDate.Enabled = false;
                txtSearchProducts.Enabled = false;
            }
            else
            {
                dateTimePickerDate.Enabled = false;
                txtSearchProducts.Enabled = true;
            }
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure to delete this data ?", "", MessageBoxButtons.YesNo);
            if(R == DialogResult.Yes)
            {
                if (Global_var.intIDChoose > 0)
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    string strSQL = "DELETE FROM staff WHERE snum=@Deleted;";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Deleted", Global_var.intIDChoose);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"Deleted successfully. \n {rows} rows of data have changed.");
                    顯示所有資料();
                }
                else
                {
                    MessageBox.Show("Error. No data is selected.");
                }
            }
        }
    }
}
