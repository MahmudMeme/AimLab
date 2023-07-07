using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
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
            string FileName = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Account file (*.acct)|*.acct";
            openFileDialog.Title = "Open a Account File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileName = openFileDialog.FileName;
                    System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    Account acc = (Account)fmt.Deserialize(strm);
                    acc.SavedPath = FileName;
                    strm.Close();
                    if (acc != null)
                    {
                        acc.SavedPath = FileName;
                        FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
                        System.Runtime.Serialization.IFormatter format = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        System.IO.FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                        Leaderboard leaderboard = (Leaderboard)format.Deserialize(stream);
                        stream.Close();
                        if(leaderboard.Accounts.Where(s => s.Name == acc.Name && s.Level == acc.Level).Any())
                        {
                            GameplayForm gameplayForm = new GameplayForm(acc);
                            gameplayForm.Location = this.Location;
                            gameplayForm.StartPosition = FormStartPosition.Manual;
                            gameplayForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show($"The file is not created from this game or is not the latest.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file \"" + FileName + "\" from disk. Original error: " + ex.Message);
                    FileName = null;
                }
            }

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
            //Leaderboard leaderboard = new Leaderboard();
            //leaderboard.LastUpdated = DateTime.Now;
            //var aaa = new Account("alo");
            //leaderboard.Accounts.Add(aaa);
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "Leaderboard file (*.ldr)|*.ldr";
            //saveFileDialog1.Title = "Save a SimpleDraw File";
            //string name = "";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    name = saveFileDialog1.FileName;
            //    System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //    System.IO.FileStream strm = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None);
            //    fmt.Serialize(strm, leaderboard);
            //    strm.Close();
            //}
        }

        private void HomeScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //string FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
            //System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            //Leaderboard leaderboard = (Leaderboard)fmt.Deserialize(strm);
            //strm.Close();
            //Account nov = new Account("Pance");
            //nov.Level = 100;
            //leaderboard.Accounts.Add(nov);
            //leaderboard.LastUpdated = DateTime.Now;
            //FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
            //System.Runtime.Serialization.IFormatter form = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //System.IO.FileStream streammm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            //form.Serialize(streammm, leaderboard);
            //streammm.Close();
            //FileName = $"{Environment.CurrentDirectory}//testing.acct";
            //System.Runtime.Serialization.IFormatter acform = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            //System.IO.FileStream acstreammm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            //acform.Serialize(acstreammm, nov);
            //acstreammm.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            string FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            Leaderboard leaderboard = (Leaderboard)fmt.Deserialize(strm);
            strm.Close();
            Account nov = new Account("Pance");
            nov.Level = 100;
            leaderboard.Accounts.Add(nov);
            leaderboard.LastUpdated = DateTime.Now;
            FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
            System.Runtime.Serialization.IFormatter form = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.FileStream streammm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            form.Serialize(streammm, leaderboard);
            streammm.Close();
            FileName = $"{Environment.CurrentDirectory}//testing.acct";
            System.Runtime.Serialization.IFormatter acform = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.FileStream acstreammm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            acform.Serialize(acstreammm, nov);
            acstreammm.Close();

        }
    }
}
