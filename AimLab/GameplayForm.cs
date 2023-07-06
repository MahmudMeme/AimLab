using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AimLab
{
    public partial class GameplayForm : Form
    {
        Random random = new Random();
        public Scene Scene { get; set; }
        public int Weith { get; set; }
        public int Heght { get; set; }
        public int TotalPoints { get; set; } = 0;
        public int Timer2Ticks { get; set; } = 0;
        public bool Gameing { get; set; } = false;
        public static int LEVELUPPOINTS { get; set; } = 50;
        public static int LEVELDOWNPOINTS { get; set; } = -100;

        public GameplayForm(Account _account)
        {
            InitializeComponent();
            Width = this.Width;
            Height = this.Height;
            DoubleBuffered = true;
            normalToolStripMenuItem.Checked = true;
            Scene = new Scene(_account);
            infoLabel.Text = $"Hello {Scene.account.Name}. Current level is {Scene.account.Level}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Gameing)
            {
                TotalPoints += Scene.HitSometing(e.Location);
                if (TotalPoints >= LEVELUPPOINTS)
                {
                    timer1.Stop();
                    Gameing = false;
                    LevelUP();
                    levelLength.Stop();
                    ShowButtons();
                }
                if (TotalPoints <= LEVELDOWNPOINTS)
                {
                    timer1.Stop();
                    Gameing = false;
                    LevelDown();
                    levelLength.Stop();
                    ShowButtons();
                }
            }
            lbTotalPoints.Text = $"Total points = {TotalPoints}  ";
            infoLabel.Text = $"Hello {Scene.account.Name}. Current level is {Scene.account.Level}";
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
            ShowButtons();

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
            Scene.account.Level = Scene.account.Level + 1;
            SetIntervalTimer1();
            Timer2Ticks = 0;
            // stopMenu.Visible = false;
            startMenu.Visible = true;
            Gameing = false;
            Scene.EmtyScene();
            TimerLeft.Text = "Successfully";
        }
        public void LevelDown()
        {
            TotalPoints = 0;
            if (Scene.account.Level > 1)
            {
                Scene.account.Level = Scene.account.Level - 1;
            }
            SetIntervalTimer1();
            Timer2Ticks = 0;

            startMenu.Visible = true;
            Gameing = false;
            Scene.EmtyScene();

            TimerLeft.Text = "Failed";
        }
        private void ResetLevel()
        {
            timer1.Stop();
            levelLength.Stop();
            TotalPoints = 0;
            lbTotalPoints.Text = $"Total points = {TotalPoints}  ";
            Timer2Ticks = 0;

            startMenu.Visible = true;
            Gameing = false;
            Scene.EmtyScene();
            ShowButtons();

            TimerLeft.Text = "Try Again";
        }
        public void MaxLevel()
        {

        }
        public void SetIntervalTimer1()
        {
            int ticks = 1000;
            int level = Scene.account.Level;
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

        private void GameplayForm_MouseMove(object sender, MouseEventArgs e)
        {

            Scene.Pointer = e.Location;
            if (Gameing)
            {
                Scene.DrawLines();
                Invalidate();
                //Cursor.Hide();
            }
            else
            {
                Invalidate();
                // Cursor.Show();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.account.CrossHairColor = dlg.Color;
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene.account.CrossHairHaveCircle = !Scene.account.CrossHairHaveCircle;
        }

        private void thinnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinnToolStripMenuItem.Checked = true;
            Scene.account.CrossHairThickness = 1;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Checked = true;
            Scene.account.CrossHairThickness = 2;
            thickToolStripMenuItem.Checked = false;
            thinnToolStripMenuItem.Checked = false;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = true;
            Scene.account.CrossHairThickness = 3;
            thinnToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SetIntervalTimer1();
            timer1.Start();
            startMenu.Visible = false;
            levelLength.Start();
            Gameing = true;
            HideButtons();
        }

        private void btnLoadGaame_Click(object sender, EventArgs e)
        {
            //todo 
        }

        private void btnSavaGame_Click(object sender, EventArgs e)
        {
            //TODO 
        }
        private void ShowButtons()
        {
            if (Scene.account.Level > 1)
            {
                btnLoadGaame.Visible = true;
                btnSavaGame.Visible = true;
            }
            btnContinue.Visible = true;
        }
        private void HideButtons()
        {
            btnContinue.Visible = false;
            btnLoadGaame.Visible = false;
            btnSavaGame.Visible = false;
        }
    }
}
