using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Database
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btndashb.Height;
            pnlNav.Top = btndashb.Top;
            pnlNav.Left = btndashb.Left;
            btndashb.BackColor = Color.FromArgb(146, 209, 163);
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(146, 209, 163);

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Card.Height;
            pnlNav.Top = Card.Top;
            pnlNav.Left = Card.Left;
            Card.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Transactions.Height;
            pnlNav.Top = Transactions.Top;
            pnlNav.Left = Transactions.Left;
            Transactions.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Settings.Height;
            pnlNav.Top = Settings.Top;
            pnlNav.Left = Settings.Left;
            Settings.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void Account_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Account.Height;
            pnlNav.Top = Account.Top;
            pnlNav.Left = Account.Left;
            Account.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void btndashb_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btndashb.Height;
            pnlNav.Top = btndashb.Top;
            pnlNav.Left = btndashb.Left;
            btndashb.BackColor = Color.FromArgb(146, 209, 163);
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void btndashb_Leave(object sender, EventArgs e)
        {
            btndashb.BackColor = Color.Transparent;
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Transparent;
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.Transparent;
        }

        private void Card_Leave(object sender, EventArgs e)
        {
            Card.BackColor = Color.Transparent;
        }

        private void Transactions_Leave(object sender, EventArgs e)
        {
            Transactions.BackColor = Color.Transparent;
        }

        private void Settings_Leave(object sender, EventArgs e)
        {
            Settings.BackColor = Color.Transparent;
        }

        private void Account_Leave(object sender, EventArgs e)
        {
            Account.BackColor = Color.Transparent;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expenses.Series["Saves"].Points.AddXY("Jan.", 2000);
            expenses.Series["Saves"].Points.AddXY("Feb.", 3000);
            expenses.Series["Saves"].Points.AddXY("Mar.", 300);
            expenses.Series["Saves"].Points.AddXY("Apr.", 2000);
            expenses.Series["Saves"].Points.AddXY("May", 1000);
            expenses.Series["Saves"].Points.AddXY("Jun.", 3000);
            expenses.Series["Saves"].Points.AddXY("July", 1500);
            expenses.Series["Saves"].Points.AddXY("Aug.", 3000);
            expenses.Series["Saves"].Points.AddXY("Sept.", 1000);
            expenses.Series["Saves"].Points.AddXY("Oct.", 500);
            expenses.Series["Saves"].Points.AddXY("Nov.", 2000);
            expenses.Series["Saves"].Points.AddXY("Dec.", 1000);

            expenses.Series["Expenses"].Points.AddXY("Jan.", 1400);
            expenses.Series["Expenses"].Points.AddXY("Feb.", 1400);
            expenses.Series["Expenses"].Points.AddXY("Mar.", 2500);
            expenses.Series["Expenses"].Points.AddXY("Apr.", 1400);
            expenses.Series["Expenses"].Points.AddXY("May", 3500);
            expenses.Series["Expenses"].Points.AddXY("Jun.", 1400);
            expenses.Series["Expenses"].Points.AddXY("July", 2000);
            expenses.Series["Expenses"].Points.AddXY("Aug.", 1400);
            expenses.Series["Expenses"].Points.AddXY("Sept.", 2800);
            expenses.Series["Expenses"].Points.AddXY("Oct.", 1400);
            expenses.Series["Expenses"].Points.AddXY("Nov.", 3400);
            expenses.Series["Expenses"].Points.AddXY("Dec.", 3100);



        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void Week_Click(object sender, EventArgs e)
        {
            Week.ForeColor = Color.Black;
        }

        private void day_Click(object sender, EventArgs e)
        {
            day.ForeColor = Color.Black; 
        }

        private void Month_Click(object sender, EventArgs e)
        {
            Month.ForeColor = Color.Black;
        }

        private void Year_Click(object sender, EventArgs e)
        {
            Year.ForeColor = Color.Black;
        }

        private void day_Leave(object sender, EventArgs e)
        {
            day.ForeColor = Color.DarkGray; 
        }

        private void Week_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Week_Leave(object sender, EventArgs e)
        {
            Week.ForeColor = Color.DarkGray;
        }

        private void Month_Leave(object sender, EventArgs e)
        {
            Month.ForeColor = Color.DarkGray;
        }

        private void Year_Leave(object sender, EventArgs e)
        {
            Year.ForeColor = Color.DarkGray;
        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
