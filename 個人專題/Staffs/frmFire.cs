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

namespace 個人專題.Staffs
{
    public partial class frmFire : frmOrderlistAdd
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        internal event Action Updated;

        public frmFire()
        {
            InitializeComponent();
        }

        private void frmFire_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true;
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            string strSQL = "UPDATE staff SET sresignation=@NewFire WHERE snum=@SearchId;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewFire", dateTimePickerFireDate.Value);
            cmd.Parameters.AddWithValue("@SearchID", Global_var.intIDChoose);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"Update successfully. Rows changed:{rows}");
            this.Close();
            Updated?.Invoke();
        }
    }
}
