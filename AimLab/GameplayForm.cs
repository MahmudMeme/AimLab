using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
        public int Timer2Ticks { get; set; } = 0;
        public bool Gameing { get; set; } = false;
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
            if (Gameing)
            {
                TotalPoints += Scene.HitSometing(e.Location);
                if (TotalPoints >= 50)
                {
                    timer1.Stop();
                    Gameing = false;
                    LevelUP();
                    levelLength.Stop();
                }
                if (TotalPoints <= -100)
                {
                    timer1.Stop();
                    Gameing = false;
                    LevelDown();
                    levelLength.Stop();
                }
            }
            lbTotalPoints.Text = $"Total points = {TotalPoints}  ";
            infoLabel.Text = $"Hello {account.Name}. Current level is {account.Level}";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }


        private Point RandomLocation()
        {
            Point Location = new Point();
            int x = random.Next(Target.MaxWidth(), Width - Target.MaxWidth());
            int y = random.Next(Target.RadiusHead, Height - Target.MaxHeght());
            Location = new Point(x, y);
            return Location;
        }



        private void GameplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetIntervalTimer1();
            timer1.Start();
            stopMenu.Visible = true;
            startMenu.Visible = false;
            levelLength.Start();
            Gameing = true;

        }

        private void stopMenu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopMenu.Visible = false;
            startMenu.Visible = true;
            levelLength.Stop();
            Gameing = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.AddTarget(RandomLocation());
            Invalidate();

            if (Timer2Ticks > 59)
            {
                ResetLevel();
            }
        }
        /*        Level 1 Pochnuva so 1000 ticks
        Level 10 Da se namaluva za Level* 50 - 500 ticks(Ticks -= Level - 1 * 50)
        Level 11- 50 Da se namaluva za Level* 5 - 200 ticks(Ticks -= (500 + (Level - 11) * 5))
        Level 51 - 100 Da se namaluva za Level* 2 - 100 ticks(Ticks -= (800 + (Level - 51) * 2))
        Level 101 - 200 Da se namaluva za Level* 1 - 0 ticks(Ticks -= (900 + (Level - 101))*/
        //Level 200 - 0 ticks - Finished Game
        public void LevelUP()
        {
            TotalPoints = 0;
            account.Level = account.Level + 1;
            SetIntervalTimer1();
            Timer2Ticks = 0;
            stopMenu.Visible = false;
            startMenu.Visible = true;
            Gameing = false;
        }
        public void LevelDown()
        {
            TotalPoints = 0;
            if (account.Level > 1)
            {
                account.Level = account.Level - 1;
            }
            SetIntervalTimer1();
            Timer2Ticks = 0;
            stopMenu.Visible = false;
            startMenu.Visible = true;
            Gameing=false;

        }
        private void ResetLevel()
        {
            timer1.Stop();
            levelLength.Stop();
            TotalPoints = 0;
            lbTotalPoints.Text = $"Total points = {TotalPoints}  ";
            Timer2Ticks = 0;
            stopMenu.Visible = false;
            startMenu.Visible = true;
            Gameing = false;
        }
        public void MaxLevel()
        {

        }
        public void SetIntervalTimer1()
        {
            int ticks = 1000;
            int level = account.Level;
            if (level > 1 && level < 11)
            {
                timer1.Interval = ticks - ((level - 1) * 50);
            }
            else if (level >= 11 && level < 51)
            {
                ticks = 500;
                timer1.Interval = ticks - ((level - 11) * 5);
            }
            else if (level >= 51 && level < 101)
            {
                ticks = 200;
                timer1.Interval = ticks - ((level - 51) * 2);
            }
            else if (level >= 101 && level < 200)
            {
                ticks = 100;
                timer1.Interval = ticks - (level - 101);
            }
            else
            {
                MaxLevel();
            }
        }
        private void levelLength_Tick(object sender, EventArgs e)
        {
            Timer2Ticks++;
            int left = 60 - Timer2Ticks;
            TimerLeft.Text = $"Time Left: {left}";
        }
    }
}
