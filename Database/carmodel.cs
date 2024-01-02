using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class carmodel : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        ); 
        public carmodel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox1.Image;
            bunifuPictureBox14.Load("carModels\\SideFront.png");
            bunifuPictureBox13.Load("carModels\\SideBack.png");
            bunifuPictureBox12.Load("carModels\\leftSide.png"); 

        }

        private void BunifuPictureBox13_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox13.Image;

        }

        private void bunifuPictureBox14_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox14.Image;
        }

        private void bunifuPictureBox12_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox12.Image;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Form f = new Dashboard();
            this.Hide();
            f.ShowDialog();
            
        }

        private void carmodel_Load(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = pictureBox1.Image;
            bunifuPictureBox14.Image = pictureBox1.Image;
            bunifuPictureBox13.Image = pictureBox1.Image;
            bunifuPictureBox12.Image = pictureBox1.Image;

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox1.Image;
            bunifuPictureBox14.Load("carModels\\SideFront.png");
            bunifuPictureBox13.Load("carModels\\SideBack.png");
            bunifuPictureBox12.Load("carModels\\leftSide.png");
        }
    }
}
