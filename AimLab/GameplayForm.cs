using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimLab
{
    public partial class GameplayForm : Form
    {
        Scene Scene = new Scene();
        Random random = new Random();
        public Account account { get; set; }
        public int Weith { get; set; }
        public int Heght { get; set; }
        public int TotalPoints { get; set; } = 0;
        public GameplayForm(Account _account)
        {
            InitializeComponent();
            Width = this.Width;
            Height = this.Height;
            DoubleBuffered = true;
            account = _account;
            infoLabel.Text = $"Hello {account.Name}. Current level is {account.Level}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            TotalPoints += Scene.HitSometing(e.Location);
            lbTotalPoints.Text = $"Total points = {TotalPoints}  ";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.AddTarget(RandomLocation());
            Invalidate();
        }
        private Point RandomLocation()
        {
            Point Location = new Point();
            int x = random.Next(Target.MaxWidth(), Width - Target.MaxWidth());
            int y = random.Next(Target.RadiusHead, Height - Target.MaxHeght());
            Location = new Point(x, y);
            return Location;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStop.Visible = true;
            btnStart.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Visible = true;
            btnStop.Visible = false;
        }

        private void GameplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
