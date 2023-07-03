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
    public partial class LeaderboardForm : Form
    {
        public Leaderboard leaderboard { get; set; }
        public LeaderboardForm()
        {
            InitializeComponent();
            no1Label.Text = string.Empty;
            no2Label.Text = string.Empty;
            no3Label.Text = string.Empty;
            no4Label.Text = string.Empty;
            no5Label.Text = string.Empty;
            no6Label.Text = string.Empty;
            no7Label.Text = string.Empty;
            no8Label.Text = string.Empty;
            no9Label.Text = string.Empty;
            no10Label.Text = string.Empty;
            string FileName = string.Empty;
            try
            {
                FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                leaderboard = (Leaderboard)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception ex)
            {
                leaderboard = new Leaderboard();
                leaderboard.LastUpdated = DateTime.Now;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                FileName = $"{Environment.CurrentDirectory}//leaderboard.ldr";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, leaderboard);
                strm.Close();

            }
            leaderboard.Accounts = leaderboard.Accounts.OrderBy(d => d.Level).ToList();
            for (int no = 1; no <= 10; no++)
            {
                int a = leaderboard.Accounts.Count();
                if (no <= a)
                {
                    no--;
                    switch (no)
                    {
                        case 0:
                            no1Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 1:
                            no2Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 2:
                            no3Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 3:
                            no4Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 4:
                            no5Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 5:
                            no6Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 6:
                            no7Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 7:
                            no8Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 8:
                            no9Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                        case 9:
                            no10Label.Text = $"1. {leaderboard.Accounts[no].Name} - Level {leaderboard.Accounts[no].Level}";
                            break;
                    }
                    no++;
                }
                else break;
            }
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
        }

        private void LeaderboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            var frm = new HomeScreenForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();

        }
    }
}
