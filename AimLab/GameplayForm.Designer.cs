namespace AimLab
{
    partial class GameplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTotalPoints = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thinnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelLength = new System.Windows.Forms.Timer(this.components);
            this.TimerLeft = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.imageGoldAim = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageGoldAim)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTotalPoints
            // 
            this.lbTotalPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalPoints.AutoSize = true;
            this.lbTotalPoints.Location = new System.Drawing.Point(12, 774);
            this.lbTotalPoints.Name = "lbTotalPoints";
            this.lbTotalPoints.Size = new System.Drawing.Size(105, 20);
            this.lbTotalPoints.TabIndex = 1;
            this.lbTotalPoints.Text = "Total Points 0";
            this.lbTotalPoints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 806);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(47, 20);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "None";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.thicknessToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1616, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // thicknessToolStripMenuItem
            // 
            this.thicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thinnToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.thickToolStripMenuItem});
            this.thicknessToolStripMenuItem.Name = "thicknessToolStripMenuItem";
            this.thicknessToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.thicknessToolStripMenuItem.Text = "Thickness";
            // 
            // thinnToolStripMenuItem
            // 
            this.thinnToolStripMenuItem.Name = "thinnToolStripMenuItem";
            this.thinnToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.thinnToolStripMenuItem.Text = "Thin";
            this.thinnToolStripMenuItem.Click += new System.EventHandler(this.thinnToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // thickToolStripMenuItem
            // 
            this.thickToolStripMenuItem.Name = "thickToolStripMenuItem";
            this.thickToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.thickToolStripMenuItem.Text = "Thick";
            this.thickToolStripMenuItem.Click += new System.EventHandler(this.thickToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.circleToolStripMenuItem.Text = "Circle ON";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // levelLength
            // 
            this.levelLength.Interval = 1000;
            this.levelLength.Tick += new System.EventHandler(this.levelLength_Tick);
            // 
            // TimerLeft
            // 
            this.TimerLeft.AutoSize = true;
            this.TimerLeft.Location = new System.Drawing.Point(12, 33);
            this.TimerLeft.Name = "TimerLeft";
            this.TimerLeft.Size = new System.Drawing.Size(101, 20);
            this.TimerLeft.TabIndex = 5;
            this.TimerLeft.Text = "Time Left: 60";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(633, 272);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(348, 107);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveGame.FlatAppearance.BorderSize = 2;
            this.btnSaveGame.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveGame.Location = new System.Drawing.Point(634, 385);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(348, 107);
            this.btnSaveGame.TabIndex = 10;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold);
            this.btnHome.Location = new System.Drawing.Point(697, 498);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(222, 81);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Go Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // imageGoldAim
            // 
            this.imageGoldAim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageGoldAim.BackgroundImage = global::AimLab.Properties.Resources._3b7340_27018874151;
            this.imageGoldAim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageGoldAim.Location = new System.Drawing.Point(643, 54);
            this.imageGoldAim.Name = "imageGoldAim";
            this.imageGoldAim.Size = new System.Drawing.Size(330, 330);
            this.imageGoldAim.TabIndex = 14;
            this.imageGoldAim.TabStop = false;
            this.imageGoldAim.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinner.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinner.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWinner.Location = new System.Drawing.Point(63, 601);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(1490, 110);
            this.lblWinner.TabIndex = 15;
            this.lblWinner.Text = "Congratulations @user you\'ve reached the last level of this game.\r\nThe golden aim" +
    " is yours, same as the first place in the leaderboard\r\n";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWinner.Click += new System.EventHandler(this.lblWinner_Click);
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 836);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.imageGoldAim);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.TimerLeft);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.lbTotalPoints);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameplayForm";
            this.Text = "Aim Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameplayForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameplayForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageGoldAim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTotalPoints;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Timer levelLength;
        private System.Windows.Forms.Label TimerLeft;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thinnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox imageGoldAim;
        private System.Windows.Forms.Label lblWinner;
    }
}

