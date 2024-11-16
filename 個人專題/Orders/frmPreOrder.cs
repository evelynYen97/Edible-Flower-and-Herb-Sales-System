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

namespace 個人專題
{
    public partial class frmPreOrder : Form
    {
        int dgv筆數 = 0;
        string strReserve1 = "Reservation";
        string strReserve2 = "Unconfirmed";
        string strlbl4 = "";

        public frmPreOrder()
        {
            InitializeComponent();
        }
        private void frmPreOrder_Load(object sender, EventArgs e)
        {
            GetOrders();
        }


        private void GetOrders()
        {
            SqlConnection con = new SqlConnection(Global_var.strDBConnectionString);
            con.Open();
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"SELECT TOP 200 o.onum [Order ID],c.companyShortName [Client name], o.odate [Order date],o.supplydate [Date of delivery],o.ototal [Total price],o.odesc [Order description],o.paymentStatus [Mode of payment],o.orderStatus [Status] FROM order_list o  JOIN order_detail od ON o.odate = od.odate JOIN clients c ON  od.cnum=c.cnum WHERE o.odesc LIKE @Status1 AND o.orderStatus LIKE @Status2 GROUP BY o.odate,o.onum,c.companyShortName,o.supplydate,o.ototal,o.odesc,o.paymentStatus,o.orderStatus ORDER BY o.supplydate ;";
            SqlCommand cmd1 = new SqlCommand(qry1, con);
            cmd1.Parameters.AddWithValue("@Status1", $"%{strReserve1}%");
            cmd1.Parameters.AddWithValue("@Status2", $"%{strReserve2}%");
            SqlDataReader reader = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.HasRows == true)
            {
                dt = new DataTable();
                dt.Load(reader);
                dgv筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數：{dgv筆數}");
            }
            reader.Close();
            con.Close();
            FlowLayoutPanel p1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 220;
                p1.Height = 650;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 0, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(1, 138, 138);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);
                p2.Padding= new Padding(10, 10, 10, 5);

                Label lbl1 = new Label();
                lbl1.ForeColor = Color.White;
                lbl1.Margin = new Padding(10, 10, 3, 0);
                lbl1.Font = new Font("Arial Rounded MT", 10);
                lbl1.AutoSize = true;

                Label lbl2 = new Label();
                lbl2.ForeColor = Color.White;
                lbl2.Margin = new Padding(10, 5, 3, 0);
                lbl2.Font = new Font("Arial Rounded MT", 10);
                lbl2.AutoSize = true;

                Label lbl3 = new Label();
                lbl3.ForeColor = Color.White;
                lbl3.Margin = new Padding(10, 5, 3, 0);
                lbl3.Font = new Font("Arial Rounded MT", 10);
                lbl3.AutoSize = true;

                Label lbl4 = new Label();
                lbl4.ForeColor = Color.White;
                lbl4.Margin = new Padding(10, 5, 3, 10);
                lbl4.Font = new Font("Arial Rounded MT", 10);
                lbl4.AutoSize = true;

                lbl1.Text = "Order Number:"+dt.Rows[i]["Order ID"].ToString();
                lbl2.Text = "Client Name:"+ dt.Rows[i]["Client name"].ToString();
                lbl3.Text = "Order date:\n"+ dt.Rows[i]["Order date"].ToString();
                string strReserved =dt.Rows[i]["Date of delivery"].ToString();
                DateTime dateReserved = default;
                DateTime.TryParse(strReserved, out dateReserved);
                strlbl4=dateReserved.ToString("yyyy-MM-dd HH:mm:ss");
                lbl4.Text = "Appointed day:\n" + strlbl4;

                p2.Controls.Add(lbl1);
                p2.Controls.Add(lbl2);
                p2.Controls.Add(lbl3);
                p2.Controls.Add(lbl4);
                p1.Controls.Add(p2);

                string strOrderTime= dt.Rows[i]["Order date"].ToString();
                DateTime dateOrder=default;
                DateTime.TryParse(strOrderTime, out dateOrder);
                string strSearch = dateOrder.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine(strOrderTime);
                Console.WriteLine(strSearch);
                string strSQL2 = @"SELECT TOP 200 od.pname [Product Name],s.container [Container (oz)],s.pweight [Product Weight],s.pprice Price,od.pamount Amount,s.packageDescription [Package Description] FROM order_detail od  JOIN order_list o ON od.odate = o.odate JOIN specifications s ON od.specificationsNum=s.specificationsNum WHERE od.odate=@Search;";
                SqlConnection con2 = new SqlConnection(Global_var.strDBConnectionString);
                con2.Open();
                SqlCommand cmd2= new SqlCommand(strSQL2, con2);
                cmd2.Parameters.AddWithValue("@Search",strSearch);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                if (reader2.HasRows == true)
                {
                    dt2 = new DataTable();
                    dt2.Load(reader2);
                    dgv筆數 = dt2.Rows.Count;
                    Console.WriteLine($"筆數：{dgv筆數}");
                }
                else
                {
                    MessageBox.Show("Connection error");
                }
                reader2.Close();
                con2.Close();
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lbl5 = new Label();
                    lbl5.ForeColor = Color.Black;
                    lbl5.Margin = new Padding(10, 5, 3, 0);
                    lbl5.Font = new Font("Arial Rounded MT", 10);
                    lbl5.AutoSize = true;
                    int intNum = 1+i + j;
                    lbl5.Text = "" + intNum + " " + dt2.Rows[j]["Product Name"].ToString() + " " + dt2.Rows[j]["Container (oz)"].ToString() + "oz × " + dt2.Rows[j]["Amount"].ToString();
                    p1.Controls.Add(lbl5);
                }

                Button btn1= new Button();
                btn1.Size = new Size(100, 35);
                btn1.Text = "Complete";
                btn1.BackColor = Color.FromArgb(1, 138, 138);
                btn1.ForeColor = Color.White;
                btn1.Font=new Font("Arial Rounded MT", 12);
                btn1.AutoSize = true;
                btn1.Margin= new Padding(40, 15, 3, 10);
                btn1.Tag=dt.Rows[i]["Order ID"].ToString();
                btn1.Click += new EventHandler (btn1_Click);
                p1.Controls.Add((Button)btn1);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int intOID = 0;
            string strComplete = "Completed";
            string strOID=(sender as System.Windows.Forms.Button).Tag.ToString();
            Int32.TryParse(strOID, out intOID);
            Console.WriteLine($"{intOID}");
            DialogResult R = MessageBox.Show("Are you sure that you want to complete this order？","",MessageBoxButtons.OKCancel);
            if (R == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Global_var.strDBConnectionString);
                    conn.Open();
                    string strSQL3 = "UPDATE order_list SET orderStatus=@Status \r\nWHERE onum=@OID;";
                    SqlCommand cmd = new SqlCommand(strSQL3, conn);
                    cmd.Parameters.AddWithValue("@Status", strComplete);
                    cmd.Parameters.AddWithValue("@OID", intOID);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Update successfully. Rows changed:{rows}");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
                GetOrders();
            }
            else
            {
                return;
            }
        }
    }
}
