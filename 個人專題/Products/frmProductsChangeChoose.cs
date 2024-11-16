using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人專題.Products
{
    public partial class frmProductsChangeChoose : frmOrderlistAdd
    {
        
        public frmProductsChangeChoose()
        {
            InitializeComponent();
            if (Global_var.strProductChangeChoose == "Add")
            {
                lblHeader.Text = "+";
                if (Global_var.intUserPrivilege == 3)
                {
                    btnChooseSpecifications.Enabled = true;
                }
                else
                {
                    btnChooseSpecifications.Enabled = false;
                }
            }
            else if (Global_var.strProductChangeChoose == "Edit")
            {
                lblHeader.Text = "✒️";
                if (Global_var.intUserPrivilege == 3)
                {
                    btnChooseSpecifications.Enabled = true;
                }
                else
                {
                    btnChooseSpecifications.Enabled = false;
                }
            }
        }

        private void frmProductsChangeChoose_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseCategory_Click(object sender, EventArgs e)
        {
            frmProductsCategoryAdd myCategoryChange = new frmProductsCategoryAdd();
            myCategoryChange.ShowDialog();
            this.Close();
        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {
            frmPrductsAdd myProductsAdd = new frmPrductsAdd();
            myProductsAdd.ShowDialog();
            this.Close();
        }

        private void btnChooseSpecifications_Click(object sender, EventArgs e)
        {
            if(Global_var.strProductChangeChoose == "Add")
            {
                frmProductsSpecificationsAdd mySpecificationChange = new frmProductsSpecificationsAdd();
                mySpecificationChange.ShowDialog();
            }
            else
            {
                frmProductsSpecificationEdit myPSpecificEdit = new frmProductsSpecificationEdit();
                myPSpecificEdit.ShowDialog();
            }
            this.Close();
        }
    }
}
