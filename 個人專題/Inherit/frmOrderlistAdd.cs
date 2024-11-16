using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 個人專題.Products;

namespace 個人專題
{
    public partial class frmOrderlistAdd : Form
    {
        public frmOrderlistAdd()
        {
            InitializeComponent();
        }


        public virtual void frmOrderlistAdd_Load(object sender, EventArgs e)
        {

        }
        internal  bool formMove = false;
        internal Point formPoint;
        internal virtual void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point(e.X, e.Y);
            formMove = true;
        }

        internal virtual void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                Point WindowPos = new Point(mousePos.X - formPoint.X, mousePos.Y - formPoint.Y);
                this.Location = WindowPos;
            }
        }

        internal virtual void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        internal virtual void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        internal virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal virtual void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
