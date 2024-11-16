using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;

namespace 個人專題
{
    public partial class frmReservation : frmOrderlistAdd
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            MonthButton();
            btnThisYear.Text = $"{DateTime.Now.Year}";
            btnNextYear.Text= $"{DateTime.Now.Year+1}";
        }
        List<Button> listDaysButton = new List<Button>();
        List<Button> listMonthButton = new List<Button>();
        internal int ThisYear = DateTime.Now.Year;
        internal int NextYear = DateTime.Now.Year+1;
        internal int YearChoose = 1;
        private void btnThisYear_Click(object sender, EventArgs e)
        {
            btnThisYear.BackColor = Color.FromArgb(185, 209, 234);
            btnNextYear.BackColor = Color.White;
            lblYear.Text = $"{ThisYear}";
            YearChoose= DateTime.Now.Year;
            foreach (Button bMonth in listMonthButton)
            {
                bMonth.BackColor = Color.White;
            }
            lblMonth.Text = "";
            foreach (Button buttonDays in listDaysButton)
            {
                buttonDays.Visible = false;
            }
            lblDay.Text = "";
        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            btnThisYear.BackColor = Color.White;
            btnNextYear.BackColor = Color.FromArgb(185, 209, 234);
            lblYear.Text = $"{NextYear}";
            YearChoose = DateTime.Now.Year + 1;
            foreach (Button bMonth in listMonthButton)
            {
                bMonth.BackColor = Color.White;
            }
            lblMonth.Text = "";
            foreach (Button buttonDays in listDaysButton)
            {
                buttonDays.Visible = false;
            }
            lblDay.Text = "";
        }

        void MonthButton()
        {

            int month = 0;
            for (int i = 0; i < 2; i += 1)
            {
                for (int j = 0; j < 6; j += 1)
                {
                    month += 1;
                    Button bMonth = new Button();
                    bMonth.BackColor = Color.White;
                    bMonth.ForeColor = Color.DarkSlateGray;
                    bMonth.Font = new Font("微軟正黑體", 18);
                    bMonth.Text = $"{month}";
                    bMonth.TextAlign = ContentAlignment.MiddleCenter;
                    bMonth.AutoSize = false;
                    bMonth.Size = new Size(55, 55);
                    bMonth.Location = new Point(35 + 57 * j, 168 + 57 * i);
                    bMonth.Name = $"btn{month}";
                    bMonth.Click += new EventHandler(bMonth_Click);
                    Controls.Add(bMonth);
                    listMonthButton.Add(bMonth);
                }
            }
        }
        internal int MonthChoose = 1;
        internal int DaysInMonth = 1;

        void bMonth_Click(object sender, EventArgs e)
        {
            foreach (Button bMonth in listMonthButton)
            {
                bMonth.BackColor = Color.White;
            }
            foreach (Button daysbutton in listDaysButton)
            {
                daysbutton.BackColor = Color.White;
            }
            lblDay.Text = "";
            Button myBtn = (Button)sender;
            if (myBtn.BackColor == Color.White)
            {
                myBtn.BackColor = Color.FromArgb(185, 209, 234);
                lblMonth.Text = myBtn.Text;
                MonthChoose = listMonthButton.IndexOf(myBtn)+1;
                DaysInMonth=DateTime.DaysInMonth(YearChoose, MonthChoose);
                DaysButton();
            }
            else
            {
                myBtn.BackColor = Color.White;
                lblMonth.Text = "";
            }
        }

        void DaysButton()
        {
            int days = 0;
            for (int i = 0; i < 3; i += 1)
            {
                for (int j = 0; j < 9; j += 1)
                {
                    days += 1;
                    Button bDays = new Button();
                    bDays.BackColor = Color.White;
                    bDays.ForeColor = Color.DarkSlateGray;
                    bDays.Font = new Font("微軟正黑體", 18);
                    bDays.Text = $"{days}";
                    bDays.TextAlign = ContentAlignment.MiddleCenter;
                    bDays.AutoSize = false;
                    bDays.Size = new Size(55, 55);
                    bDays.Location = new Point(24 + 57 * j, 330 + 57 * i);
                    bDays.Name = $"btn{days}";
                    bDays.Click += new EventHandler(bDays_Click);
                    Controls.Add(bDays);
                    listDaysButton.Add(bDays);
                }
            }
            listDaysButton.Add(btn28);
            listDaysButton.Add(btn29);
            listDaysButton.Add(btn30);
            listDaysButton.Add(btn31);

            if (DaysInMonth == 28)
            {
                btn28.Visible = true;
                btn29.Visible = false;
                btn30.Visible = false;
                btn31.Visible = false;
            }
            else if(DaysInMonth == 29)
            {
                btn28.Visible = true;
                btn29.Visible = true;
                btn30.Visible = false;
                btn31.Visible = false;
            }
            else if (DaysInMonth == 30)
            {
                btn28.Visible = true;
                btn29.Visible = true;
                btn30.Visible = true;
                btn31.Visible = false;
            }
            else if (DaysInMonth == 31)
            {
                btn28.Visible = true;
                btn29.Visible = true;
                btn30.Visible = true;
                btn31.Visible = true;
            }
                
        }

        void bDays_Click(object sender, EventArgs e)
        {
            foreach (Button buttonsDays in listDaysButton)
            {
                buttonsDays.BackColor = Color.White;
            }

            Button myBtn = (Button)sender;
            if (myBtn.BackColor == Color.White)
            {
                myBtn.BackColor = Color.FromArgb(185, 209, 234);
                lblDay.Text = myBtn.Text;
            }
            else
            {
                myBtn.BackColor = Color.White;
                lblDay.Text = "";
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            foreach (Button buttonsDays in listDaysButton)
            {
                buttonsDays.BackColor = Color.White;
            }
            btn28.BackColor = Color.FromArgb(185, 209, 234);
            lblDay.Text = "28";
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            foreach (Button buttonsDays in listDaysButton)
            {
                buttonsDays.BackColor = Color.White;
            }
            btn29.BackColor = Color.FromArgb(185, 209, 234);
            lblDay.Text = "29";
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            foreach (Button buttonsDays in listDaysButton)
            {
                buttonsDays.BackColor = Color.White;
            }
            btn30.BackColor = Color.FromArgb(185, 209, 234);
            lblDay.Text = "30";
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            foreach (Button buttonsDays in listDaysButton)
            {
                buttonsDays.BackColor = Color.White;
            }
            btn31.BackColor = Color.FromArgb(185, 209, 234);
            lblDay.Text = "31";
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if(lblYear.Text!=""&& lblMonth.Text != "" && lblDay.Text != "")
            {
                string strReservationDate = $"{lblYear.Text}-{lblMonth.Text}-{lblDay.Text}";
                DateTime dateTimeReservation= DateTime.Parse(strReservationDate);
                Console.WriteLine($"{dateTimeReservation}");
                if (dateTimeReservation > DateTime.Today.AddDays(1))
                {
                    Global_var.date預訂供貨日 = dateTimeReservation;
                    Global_var.strReservation = "Reservation";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The reservation time is too early.");
                    Global_var.strReservation = "";
                }
            }
            else
            {
                MessageBox.Show("Incomplete date");
            }
        }
    }

}

        

            


    






