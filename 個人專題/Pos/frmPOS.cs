using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Documents;
using 個人專題.Pos;

namespace 個人專題
{
    public partial class frmPOS : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listPosCategories = new List<string>();
        List<Button> list類別按鈕 = new List<Button>();
        List<string> list商品名稱 = new List<string>();
        List<int> listId = new List<int>();
        //ucRoundButton customButton = new ucRoundButton();
        //ucRoundButton.Text = "Click me";
        //ucRoundButton.Size = new Size(100, 40);
        //this.Controls.Add(ucRoundButton);

        public frmPOS()
        {
            InitializeComponent();
        }


        private void frmPOS_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT TOP 200 * FROM products_categories;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                listPosCategories.Clear();
                while (reader.Read())
                {
                    string strCategory = reader["categoriesName"].ToString().Trim();
                    listPosCategories.Add(strCategory);
                }
                reader.Close();
                string strSQL2 = "SELECT companyShortName FROM clients ORDER BY companyShortName;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cBoxClientsName.Items.Add(reader2["companyShortName"].ToString().Trim());
                }
                reader2.Close();
                
                strSQL = "SELECT TOP 200 * FROM products WHERE productsSeedStock != 0 ORDER BY productsName;";
                cmd = new SqlCommand(strSQL, con);
                reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    listId.Add((int)reader["pNum"]);
                    list商品名稱.Add((string)reader["productsName"]);
                    string image_name = (string)reader["productsPicture"];
                    string 完整圖檔路徑 = $"{Global_var.image_dir}\\{image_name}"; 
                    System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑); 
                    Image img商品圖檔 = Image.FromStream(fs);
                    imageList商品圖檔.Images.Add(img商品圖檔);
                    fs.Close(); 
                    count++;
                }
                reader.Close();
                con.Close();
                Console.WriteLine($"讀取了{count}筆資料");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            顯示ListView圖片模式();
            CategoriesButton();
        }

        void 顯示ListView圖片模式() 
        { 
            listViewProducts.Clear();
            listViewProducts.View = View.LargeIcon; 
            imageList商品圖檔.ImageSize = new Size(140,140);
            listViewProducts.LargeImageList = imageList商品圖檔;
            for (int i = 0; i < listId.Count; i++) 
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{list商品名稱[i]}";
                item.Font = new Font("Arvo", 12);
                item.ForeColor = Color.FromArgb(0, 139, 139);
                item.Tag = listId[i];
                listViewProducts.Items.Add(item);
            }
        }

        void CategoriesButton()
        {
            
            for (int i = 0; i < listPosCategories.Count(); i += 1)
            {
                int 避免重名 = i;
                Button dbutton = new Button();
                dbutton.BackColor = Color.FromArgb(153, 180, 209);
                dbutton.ForeColor = Color.White;
                dbutton.Font = new Font("Arial Rounded MT", 14);
                dbutton.Text = $"{listPosCategories[i]}";
                dbutton.TextAlign = ContentAlignment.MiddleCenter;
                dbutton.Size = new Size(176, 60);
                dbutton.Location = new Point(22, 231 + 63 * i);
                dbutton.Name = $"btn{listPosCategories[i]}{避免重名}";
                dbutton.Click += new EventHandler(dbutton_Click);
                Controls.Add(dbutton);
                list類別按鈕.Add(dbutton);
            }
        }

        private void dbutton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            string strSearchCategory = myBtn.Text.Trim();
            try
            {
                string strSQL = "SELECT TOP 200 * FROM products p JOIN products_categories pc ON p.categoriesNum=pc.categoriesNum WHERE pc.categoriesName=@Search AND productsSeedStock != 0 ORDER BY productsName;";
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Search", strSearchCategory);
                SqlDataReader reader = cmd.ExecuteReader();
                listId.Clear();
                list商品名稱.Clear();
                imageList商品圖檔.Images.Clear();
                int count = 0;
                while (reader.Read())
                {
                    listId.Add((int)reader["pNum"]);
                    list商品名稱.Add((string)reader["productsName"]);
                    string image_name = (string)reader["productsPicture"];
                    string 完整圖檔路徑 = $"{Global_var.image_dir}\\{image_name}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
                    Image img商品圖檔 = Image.FromStream(fs);
                    imageList商品圖檔.Images.Add(img商品圖檔);
                    fs.Close();
                    count++;
                }
                reader.Close();
                con.Close();
                Console.WriteLine($"讀取了{count}筆資料");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            顯示ListView圖片模式();
        }

        private void pBoxClosePos_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Are you sure that you want to shut down the Pos system？", "Pos system is closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

        private void pBoxClosePos_MouseHover(object sender, EventArgs e)
        {
            pBoxClosePos.BackColor=Color.CadetBlue;
        }
        private void btnDelivery_MouseHover(object sender, EventArgs e)
        {
            btnDelivery.BackColor = Color.FromArgb(185, 209, 234);
        }

        private void btnTakeAway_MouseHover(object sender, EventArgs e)
        {
            btnTakeAway.BackColor = Color.FromArgb(185, 209, 234);
        }

        private void btnReservation_MouseHover(object sender, EventArgs e)
        {
            btnReservation.BackColor = Color.FromArgb(185, 209, 234);
        }

        private void pBoxClosePos_MouseLeave(object sender, EventArgs e)
        {
            pBoxClosePos.BackColor = Color.FromArgb(3, 32, 60);
        }
        private void btnDelivery_MouseLeave(object sender, EventArgs e)
        {
            btnDelivery.BackColor = Color.FromArgb(215, 228, 242);
        }

        private void btnTakeAway_MouseLeave(object sender, EventArgs e)
        {
            btnTakeAway.BackColor = Color.FromArgb(215, 228, 242);
        }

        private void btnReservation_MouseLeave(object sender, EventArgs e)
        {
            btnReservation.BackColor = Color.FromArgb(215, 228, 242);
        }
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            frmDeliveryChoose myDelivery=new frmDeliveryChoose();
            myDelivery.ShowDialog();
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            frmTakeAwayChoose mySelfPickup = new frmTakeAwayChoose();
            mySelfPickup.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation myReservation=new frmReservation();
            myReservation.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if ((cBoxClientsName.SelectedIndex!=-1)&&(lblOrder.Text!="")&&(lBoxOrderDetails.Items.Count>0))
            {
                Global_var.str訂購人姓名=cBoxClientsName.Text.Trim();
                frmCheckOut myCheckOut = new frmCheckOut();
                myCheckOut.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please confirm that the shipping method,products and client have been selected. ");
            }
        }

        private void listViewProducts_ItemActivate(object sender, EventArgs e)
        {
            frmProductsDetialChoose myPDetil =new frmProductsDetialChoose();
            Global_var.intPID= (int)listViewProducts.SelectedItems[0].Tag;
            Global_var.strProductName=listViewProducts.SelectedItems[0].Text;
            myPDetil.ShowDialog();
        }

        void 加載購物車内容()
        {
            List<int> listSubTotal = new List<int>();
            lBoxOrderDetails.Items.Clear();
            foreach (ArrayList item in Global_var.listOrderItems)
            {
                string PName = (string)item[0];
                int SpecificationID = (int)item[1];
                int Amount = (int)item[2];
                int Price = (int)item[3];
                int Container = (int)item[5];
                int Total = Amount * Price;
                listSubTotal.Add(Total);
                lBoxOrderDetails.Items.Add($"{PName} {Container} oz x {Amount} = {Total} $");
            }
            int intSubtotal = listSubTotal.Sum();
            lblTotal.Text = intSubtotal.ToString();
        }

        private void frmPOS_Activated(object sender, EventArgs e)
        {
            加載購物車内容();
            lblOrder.Text = Global_var.str送貨方式;
            lblReservation.Text = Global_var.strReservation;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lBoxOrderDetails.Items.Clear();
            Global_var.listOrderItems.Clear();
        }

        private void btnReservationCancel_Click(object sender, EventArgs e)
        {
            lblReservation.Text = "";
            Global_var.strReservation = "";
            Global_var.date預訂供貨日=default;
        }

        private void btnAllCategories_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "SELECT TOP 200 * FROM products WHERE productsSeedStock != 0 ORDER BY productsName;";
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                listId.Clear();
                list商品名稱.Clear();
                imageList商品圖檔.Images.Clear();
                int count = 0;
                while (reader.Read())
                {
                    listId.Add((int)reader["pNum"]);
                    list商品名稱.Add((string)reader["productsName"]);
                    string image_name = (string)reader["productsPicture"];
                    string 完整圖檔路徑 = $"{Global_var.image_dir}\\{image_name}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
                    Image img商品圖檔 = Image.FromStream(fs);
                    imageList商品圖檔.Images.Add(img商品圖檔);
                    fs.Close();
                    count++;
                }
                reader.Close();
                con.Close();
                Console.WriteLine($"讀取了{count}筆資料");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            顯示ListView圖片模式();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lBoxOrderDetails.SelectedIndex >= 0)
            {
                int selectIdx = lBoxOrderDetails.SelectedIndex;
                lBoxOrderDetails.Items.RemoveAt(selectIdx);
                Global_var.listOrderItems.RemoveAt(selectIdx);
                加載購物車内容();
            }
            else
            {
                MessageBox.Show("Please choose the item to delete.");
            }
        }
    }
}
