using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人專題
{
    public partial class frmDeliveryChoose :frmOrderlistAdd
    {
        public frmDeliveryChoose()
        {
            InitializeComponent();
        }

        private void frmDeliveryChoose_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strDeliveryWayChoose = "黑貓";
            Global_var.intDeliveryPrice = 160;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strDeliveryWayChoose = "順豐";
            Global_var.intDeliveryPrice = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strDeliveryWayChoose = "lalamove";
            Global_var.intDeliveryPrice = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Global_var.strDeliveryWayChoose = "店家配送";
            Global_var.intDeliveryPrice = 100;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (Global_var.strDeliveryWayChoose != "")
            {
                Global_var.str送貨方式 = "Delivery order";
                Global_var.date下單日 = DateTime.Now;
                Global_var.date供貨日= DateTime.Today;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose a delivery way.");
            }
        }
    }
}
