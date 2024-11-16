using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 個人專題.Inherit;
using 個人專題.Staffs;
using System.Data.SqlClient;

namespace 個人專題.Clients
{
    public partial class frmClients :frmMainViewAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int dgv筆數 = 0;
        string strSQL = "";
        public frmClients()
        {
            InitializeComponent();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            顯示所有資料();
            cBoxSearch.Items.Add("company name");
            cBoxSearch.Items.Add("company short name");
            cBoxSearch.Items.Add("cotact name");
            cBoxSearch.Items.Add("phone");
            cBoxSearch.Items.Add("Email");



        }

        private void 顯示所有資料()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT cnum ID,companyName [Company Name],companyShortName [Short Name],ccontactName [Contact Name],cphone1 [Phone 1],cphone2 [Phone 2],cemail Email,caddress1 [Address 1],caddress2 [Address 2],cpayment Payment,shipping [Shipping Way],cstatus [Client Status]\r\nFROM clients";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvClients.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            Global_var.strProductChangeChoose = "Add";
            
        }

        internal override void btnEdit_Click(object sender, EventArgs e)
        {
            Global_var.strProductChangeChoose = "Edit";
            
        }
        internal override void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
