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

namespace 個人專題.Clients
{
    public partial class frmClientsAdd : frmEditAdd
    {
        public frmClientsAdd()
        {
            InitializeComponent();
        }

        private void frmClientsAdd_Load(object sender, EventArgs e)
        {
            if (Global_var.strProductChangeChoose == "Add")
            {
                btnOK.Text = "Add";
                lblName.Text = "New Client";
            }
            else
            {
                btnOK.Text = "Save";
                lblName.Text = "Client";
            }
        }
    }
}
