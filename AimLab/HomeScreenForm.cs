using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        //btnNewGame
        private void button1_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            try
            {
                string FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                leaderboard = (Leaderboard)fmt.Deserialize(strm);
                strm.Close();
            }
            catch
            {

            }
            InputDialogForm formName = new InputDialogForm(leaderboard);
            if (formName.ShowDialog() == DialogResult.OK)
            {
                Account account = new Account(formName.textBox1.Text);
                GameplayForm gameplayForm = new GameplayForm(account);
                gameplayForm.Location = this.Location;
                gameplayForm.StartPosition = FormStartPosition.Manual;
                gameplayForm.Show();
                this.Hide();
            }
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            var frm = new LeaderboardForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
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
            if (sureToClose == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.LastUpdated = DateTime.Now;
            var aaa = new Account("alo");
            leaderboard.Accounts.Add(aaa);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Leaderboard file (*.ldr)|*.ldr";
            saveFileDialog1.Title = "Save a SimpleDraw File";
            string name = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, leaderboard);
                strm.Close();
            }
        }

        private void HomeScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
