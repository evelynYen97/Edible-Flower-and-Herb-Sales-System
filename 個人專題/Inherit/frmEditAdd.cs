using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人專題.Inherit
{
    public partial class frmEditAdd : Form
    {
        public frmEditAdd()
        {
            InitializeComponent();
        }

        internal virtual void frmEditAdd_Load(object sender, EventArgs e)
        {

        }

        internal virtual void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal virtual void btnOK_Click(object sender, EventArgs e)
        {

        }

        internal virtual void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
