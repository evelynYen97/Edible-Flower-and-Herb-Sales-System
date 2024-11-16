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
    public partial class frmTakeAwayChoose : frmOrderlistAdd
    {
        string strTakeAwayTime = "";
        string strTakeAwayDay = DateTime.Today.ToString("yyyy-MM-dd");

        public frmTakeAwayChoose()
        {
            InitializeComponent();
        }
        

        private void frmTakeAwayChoose_Load(object sender, EventArgs e)
        {
          
        }


        private void btnToday_Click(object sender, EventArgs e)
        {
            btnToday.BackColor = Color.LightSteelBlue;
            btnTomorrow.BackColor= Color.White;
            strTakeAwayDay = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            btnToday.BackColor = Color.White;
            btnTomorrow.BackColor = Color.LightSteelBlue;
            strTakeAwayDay = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
        }

        private void rbtn1400_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "14:00";
        }

        private void rbtn1430_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "14:30";
        }

        private void rbtn1500_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "15:00";
        }

        private void rbtn1530_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "15:30";
        }

        private void rbtn1600_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "16:00";
        }

        private void rbtn1630_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "16:30";
        }

        private void rbtnUrgent_CheckedChanged(object sender, EventArgs e)
        {
            strTakeAwayTime = "Urgent";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (strTakeAwayDay != "" && strTakeAwayTime != ""&& strTakeAwayTime != "Urgent")
            {
                string strDatetime = $"{strTakeAwayDay} {strTakeAwayTime}";
                DateTime dateTimeTakeaway = DateTime.Parse(strDatetime);
                Global_var.date下單日=DateTime.Now;
                Global_var.date供貨日 = dateTimeTakeaway;
                Global_var.str送貨方式 = "Self-pickup Order";
                Global_var.strDeliveryWayChoose = "Self-pickup";
                this.Close();
            }
            else if(strTakeAwayTime == "Urgent")
            {
                Global_var.date下單日 = DateTime.Now;
                Global_var.date供貨日 = DateTime.Now;
                Global_var.str送貨方式 = "Urgent Self-pickup order";
                Global_var.strDeliveryWayChoose = "Urgent Self-pickup";
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a pickup time.");
            }
        }
    }
}
