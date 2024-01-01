using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class carmodel : Form
    {
        public carmodel()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            bunifuPictureBox11.Image = bunifuPictureBox1.Image;
            bunifuPictureBox14.Load("carModels\\SideFront.png");
            bunifuPictureBox13.Load("carModels\\SideBack.png");
            bunifuPictureBox12.Load("carModels\\leftSide.png"); 

        }

        private void bunifuPictureBox13_Click(object sender, EventArgs e)
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
    }
}
