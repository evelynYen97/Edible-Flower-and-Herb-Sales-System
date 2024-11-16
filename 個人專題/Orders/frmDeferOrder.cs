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

namespace 個人專題.Orders
{
    public partial class frmDeferOrder : frmOrderlistAdd
    {
        public frmDeferOrder()
        {
            InitializeComponent();
        }

        private void frmDeferOrder_Load(object sender, EventArgs e)
        {
            lblDeliveryDateNow.Text = Global_var.strOSupplyDate;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            DateTime dateDefer=dateTimePickerDefer.Value;
            DateTime dateDeferTo=default;
            DateTime.TryParse(Global_var.strOSupplyDate, out dateDeferTo);
            if(dateDefer > dateDeferTo)
            {
                DialogResult R = MessageBox.Show("Are you sure to defer order?", "", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    if (Global_var.intOID > 0)
                    {
                        string strAddReserve = "Reservation";
                        SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                        string strSQL = "UPDATE order_list SET supplydate=@DeferDate,odesc = odesc+@Add WHERE onum=@OID;";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@DeferDate", dateDefer);
                        cmd.Parameters.AddWithValue("@OID", Global_var.intOID);
                        cmd.Parameters.AddWithValue("@Add", strAddReserve);
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"Supply date update successfully. \n {rows} rows of data have changed.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error. No data is selected.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error.Date selected should not be earlier than the time on the order.");
            }
           
        }
    }
}
