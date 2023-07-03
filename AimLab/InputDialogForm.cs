using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimLab
{
    public partial class InputDialogForm : Form
    {
        public Leaderboard leaderboard { get; set; }
        public InputDialogForm(Leaderboard _leaderboard)
        {
            InitializeComponent();
            leaderboard = _leaderboard;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void clearTextButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(leaderboard.Accounts.Where(s => s.Name == textBox1.Text).Any())
            {
                errorLabel.Text = "This username is already in use";
            }
            else
                DialogResult = DialogResult.OK;
        }
    }
}
