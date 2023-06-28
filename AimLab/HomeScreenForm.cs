using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimLab
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var sureToClose = MessageBox.Show("You are going to exit, are you sure you want that?", "Exit", MessageBoxButtons.YesNo);
            if(sureToClose == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
