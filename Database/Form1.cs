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
    }
}
