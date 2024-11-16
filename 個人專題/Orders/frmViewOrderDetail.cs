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

namespace 個人專題.Orders
{
    public partial class frmViewOrderDetail : frmEditAdd
    {
        string strSQL = "";
        int dgv筆數 = 0;
        public frmViewOrderDetail()
        {
            InitializeComponent();
        }

        private void frmViewOrderDetail_Load(object sender, EventArgs e)
        {
            lblOID.Text=Global_var.intOID.ToString();

            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            if (Global_var.intUserPrivilege == 3)
            {
                strSQL = "SELECT TOP 200  od.pname [Product Name],s.container [Container (oz)],s.pweight [Product Weight],s.pprice Price,od.pamount Amount,s.packageDescription [Package Description] FROM order_detail od  JOIN order_list o ON od.odate = o.odate JOIN specifications s ON od.specificationsNum=s.specificationsNum WHERE od.odate = @SearchDate;";
            }
            else
            {
                strSQL = "SELECT TOP 200  od.pname [Product Name],s.container [Container (oz)],s.pweight [Product Weight],od.pamount Amount,s.packageDescription [Package Description] FROM order_detail od  JOIN order_list o ON od.odate = o.odate  JOIN specifications s ON od.specificationsNum=s.specificationsNum WHERE od.odate = @SearchDate;";
            }
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchDate", Global_var.strOOrderDate);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {   
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
                dgvOrderDetail.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
    }
}
