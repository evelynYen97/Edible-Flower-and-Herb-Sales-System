using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace 個人專題.Pos
{
    public partial class frmProductsDetialChoose : frmOrderlistAdd
    {
        List<Button> list規格類別按鈕 = new List<Button>();
        List<int> list規格Id = new List<int>();
        List<int> listPSContainer = new List<int>();
        List<double> listPSWeight = new List<double>();
        List<int> listPSPrice = new List<int>();
        int intChooseAmount = 0;
        public frmProductsDetialChoose()
        {
            InitializeComponent();
        }

        private void frmProductsDetialChoose_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT * FROM specifications WHERE pNum=@ProductID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ProductID",Global_var.intPID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int intSID = 0;
                    Int32.TryParse(reader["specificationsNum"].ToString().Trim(), out intSID);
                    list規格Id.Add(intSID);
                    int intContainer = 0;
                    Int32.TryParse(reader["container"].ToString().Trim(), out intContainer);
                    listPSContainer.Add(intContainer);
                    double dPW = 0.00;
                    Double.TryParse(reader["pweight"].ToString().Trim(), out dPW);
                    listPSWeight.Add(dPW);
                    int dPrice = 0;
                    Int32.TryParse(reader["pprice"].ToString().Trim(), out dPrice);
                    listPSPrice.Add(dPrice);
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            SpecificationButton();
            AmountButtons();
            lblProductChoose.Text=Global_var.strProductName;
            txtAmount.Text = "1";
        }

        void SpecificationButton()
        {
            for (int i = 0; i < list規格Id.Count(); i += 1)
            {
                Button dbutton = new Button();
                dbutton.BackColor = Color.White;
                dbutton.ForeColor = Color.Black;
                dbutton.Font = new Font("微軟正黑體", 12);
                dbutton.Text = $"Container: {listPSContainer[i]} oz\n\nWeight: {listPSWeight[i]} g";
                dbutton.TextAlign = ContentAlignment.MiddleLeft;
                dbutton.Padding = new Padding(10,10,10,10);
                dbutton.Size = new Size(180,110);
                dbutton.Location = new Point(35+215*i,154);
                dbutton.Name = $"btnSpecification{list規格Id[i]}";
                dbutton.Tag=list規格Id[i];
                dbutton.Click += new EventHandler(dbutton_Click);
                Controls.Add(dbutton);
                list規格類別按鈕.Add(dbutton);
            }
        }

        private void dbutton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            foreach (Button btn in list規格類別按鈕)
            {
                btn.BackColor = Color.White;
            }
            if (myBtn.BackColor == Color.White)
            {
                myBtn.BackColor = Color.Pink;
                Global_var.intSID=(int)myBtn.Tag;
            }
            else
            {
                myBtn.BackColor = Color.White;
                Global_var.intSID = -1;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                bool isCorrectAmount = Int32.TryParse(txtAmount.Text, out intChooseAmount); //建立bool 用於判斷是否正確輸入杯數
                if ((isCorrectAmount) && (intChooseAmount > 0) && (intChooseAmount < 100))
                {
                    Int32.TryParse(txtAmount.Text,out intChooseAmount);
                }
                else
                {
                    MessageBox.Show("Wrong input. The amount should be 1-99.");
                    intChooseAmount = 1;
                    txtAmount.Text = intChooseAmount.ToString();
                }

            }
        }

        private void btn減_Click(object sender, EventArgs e)
        {
            bool is輸入正確 = Int32.TryParse(txtAmount.Text, out intChooseAmount);
            if ((is輸入正確) && (intChooseAmount > 0) && (intChooseAmount < 100))
            {
                txtAmount.Text = (intChooseAmount - 1).ToString();
            }
        }

        private void btn加_Click(object sender, EventArgs e)
        {
            bool is輸入正確 = Int32.TryParse(txtAmount.Text, out intChooseAmount);
            if ((is輸入正確) && (intChooseAmount > 0) && (intChooseAmount < 100))
            {
                txtAmount.Text = (intChooseAmount + 1).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Text="1";
        }

        private void AmountButtons()
        {
            for (int i = 0; i <= 9; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Name = $"btnNum{i}";
                button.Font = new Font("微軟正黑體", 14,FontStyle.Bold);
                button.Size = new System.Drawing.Size(60, 60);
                button.Location = new System.Drawing.Point(48 +69*i, 387);
                button.Click += Button_Click; 
                this.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btnNum = sender as Button;
            bool is輸入正確 = Int32.TryParse(txtAmount.Text, out intChooseAmount);
            if ((is輸入正確) && (intChooseAmount > 0) && (intChooseAmount < 100))
            {
                if (btnNum != null)
                {
                    txtAmount.AppendText(btnNum.Text);
                }
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (Global_var.intSID >= 0)
            {
                int index = list規格Id.IndexOf(Global_var.intSID);
                int dPrice = listPSPrice[index];
                double dWeight = listPSWeight[index];
                int dContainer =listPSContainer[index];
                ArrayList OrderItemDetail = new ArrayList();
                OrderItemDetail.Add(Global_var.strProductName);
                OrderItemDetail.Add(Global_var.intSID);
                OrderItemDetail.Add(intChooseAmount);
                OrderItemDetail.Add(dPrice);
                OrderItemDetail.Add(dWeight);
                OrderItemDetail.Add(dContainer);
                Global_var.listOrderItems.Add(OrderItemDetail);
                MessageBox.Show("The selected item has been added to the cart.");
            }
            else
            {
                MessageBox.Show("Please choose one  specification.");
            }
        }
    }
}
