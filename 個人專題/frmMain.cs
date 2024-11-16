using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 個人專題.Inherit;
using System.Data.SqlClient;
using 個人專題.Clients;

namespace 個人專題
{
    public partial class frmMain : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string str修改後的圖檔名稱 = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {   
            scsb.DataSource = @".";
            scsb.InitialCatalog = "個人專題";
            scsb.IntegratedSecurity = true; 
            Global_var.strDBConnectionString = scsb.ConnectionString.ToString();

            btnPreOrder.Visible = false;
            btnHistoryOrder.Visible = false;
            picFlowers.Visible = false;
            picHerbs.Visible = false;
            panelMoving.Location = new Point(0, 230);
            lblUserName1.Text = Global_var.strUserName;
            lblUserName2.Text= Global_var.strUserName;
            string strSQL = "SELECT * FROM user_login Where userID=@UID";
            if (Global_var.intUID > 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@UID", Global_var.intUID);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        str修改後的圖檔名稱 = read["uphoto"].ToString();
                        string str完整圖檔路徑 = $"{Global_var.image_dirLogin}\\{str修改後的圖檔名稱}";
                        System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                        pictureBoxUser1.Image = Image.FromStream(fs);
                        pictureBoxUser2.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Connection error.");
                }
            }
            if (Global_var.intUserPrivilege == 0)
            {
                btnHome.Enabled = false;
                btnOrders.Enabled = false;
                btnHistoryOrder.Enabled = false;
                btnPreOrder.Enabled = false;
                btnProducts.Enabled = false;
                btnStaff.Enabled = false;
                btnClients.Enabled = false;
                btnPosSystem.Enabled = false;
            }
        }

        private bool formMove = false;
        private Point formPoint;
        private void pnlTopControl_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point(e.X, e.Y);
            formMove = true;
        }

        private void pnlTopControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                Point WindowPos = new Point(mousePos.X - formPoint.X, mousePos.Y - formPoint.Y);
                this.Location = WindowPos;
            }
        }

        private void pnlTopControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Do you want to close the system?", "System is closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnPosSystem_Click(object sender, EventArgs e)
        {
            關閉次目錄();
            frmPOS myfrmPOS = new frmPOS();
            myfrmPOS.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Home";
            if (Global_var.intUserPrivilege == 3)
            {
                AddControls(new frmHome1());
            }
            else
            {
                AddControls(new frmLimitedHome());
            }
            關閉次目錄();
        }

        private void 關閉次目錄()
        {
            if ((btnPreOrder.Visible == true) && (btnHistoryOrder.Visible == true))
            {
                btnPreOrder.Visible = false;
                btnHistoryOrder.Visible = false;
                picFlowers.Visible = false;
                picHerbs.Visible = false;
                StartMoving();
            }
        }
        
        private void btnOrders_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Orders";
            AddControls(new frmOrders());
            if ((btnPreOrder.Visible == true)&& (btnHistoryOrder.Visible == true))
            {
                btnPreOrder.Visible = false;
                btnHistoryOrder.Visible = false;
                picFlowers.Visible = false;
                picHerbs.Visible = false;
                StartMoving();
            }
            else
            {
                btnPreOrder.Visible = true;
                btnHistoryOrder.Visible = true;
                picFlowers.Visible = true;
                picHerbs.Visible = true;
                StartBackMoving();
            }
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Orders_Pre-Order";
            AddControls(new frmPreOrder());
        }

        private void btnHistoryOrder_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Orders_History Orders";
            AddControls(new frmHistoryOrders());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Products";
            關閉次目錄();
            AddControls(new frmProducts());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Staffs";
            關閉次目錄();
            if(Global_var.intUserPrivilege==3 || Global_var.intUserPrivilege == 2)
            {
                AddControls(new frmStaffs());
            }
            else
            {
                MessageBox.Show("Insufficient permissions to view.");
            }
            
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            lblTitelChange.Text = "Clients";
            關閉次目錄();
            if (Global_var.intUserPrivilege == 3)
            {
                AddControls(new frmClients());
            }
            else
            {
                MessageBox.Show("Insufficient permissions to view.");
            }
            
        }

        private void Movetimer_Tick(object sender, EventArgs e)
        {
            panelMoving.Location = new Point(panelMoving.Location.X, panelMoving.Location.Y-5);
            if (panelMoving.Location.Y <= 231)
            {
                Movetimer.Stop();
            }
        }
        private void StartMoving()
        {
            panelMoving.Location = new Point(0, 310);
            Movetimer.Start();
        }

        private void BackMoving_Tick(object sender, EventArgs e)
        {
            panelMoving.Location = new Point(panelMoving.Location.X, panelMoving.Location.Y + 5);
            if (panelMoving.Location.Y >= 309)
            {
                BackMoving.Stop();
            }
        }

         void StartBackMoving()
        {
            panelMoving.Location = new Point(0, 230);
                BackMoving.Start();
        }

        //在Main form加切換頁面的方法
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

      
    }
}
