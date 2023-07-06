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
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thinnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelLength = new System.Windows.Forms.Timer(this.components);
            this.TimerLeft = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnLoadGaame = new System.Windows.Forms.Button();
            this.btnSavaGame = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTotalPoints
            // 
            this.lbTotalPoints.AutoSize = true;
            this.lbTotalPoints.Location = new System.Drawing.Point(11, 621);
            this.lbTotalPoints.Name = "lbTotalPoints";
            this.lbTotalPoints.Size = new System.Drawing.Size(88, 16);
            this.lbTotalPoints.TabIndex = 1;
            this.lbTotalPoints.Text = "Total Points 0";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(11, 646);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(44, 16);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu,
            this.colorToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.thicknessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startMenu
            // 
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(60, 24);
            this.startMenu.Text = "Menu";
            this.startMenu.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // thicknessToolStripMenuItem
            // 
            this.thicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thinnToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.thickToolStripMenuItem});
            this.thicknessToolStripMenuItem.Name = "thicknessToolStripMenuItem";
            this.thicknessToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.thicknessToolStripMenuItem.Text = "Thickness";
            // 
            // thinnToolStripMenuItem
            // 
            this.thinnToolStripMenuItem.Name = "thinnToolStripMenuItem";
            this.thinnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thinnToolStripMenuItem.Text = "Thin";
            this.thinnToolStripMenuItem.Click += new System.EventHandler(this.thinnToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // thickToolStripMenuItem
            // 
            this.thickToolStripMenuItem.Name = "thickToolStripMenuItem";
            this.thickToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thickToolStripMenuItem.Text = "Thick";
            this.thickToolStripMenuItem.Click += new System.EventHandler(this.thickToolStripMenuItem_Click);
            // 
            // levelLength
            // 
            this.levelLength.Interval = 1000;
            this.levelLength.Tick += new System.EventHandler(this.levelLength_Tick);
            // 
            // TimerLeft
            // 
            this.TimerLeft.AutoSize = true;
            this.TimerLeft.Location = new System.Drawing.Point(1263, 42);
            this.TimerLeft.Name = "TimerLeft";
            this.TimerLeft.Size = new System.Drawing.Size(95, 16);
            this.TimerLeft.TabIndex = 5;
            this.TimerLeft.Text = "TIME LEFT: 60";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(560, 146);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(183, 70);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Play";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnLoadGaame
            // 
            this.btnLoadGaame.Location = new System.Drawing.Point(560, 237);
            this.btnLoadGaame.Name = "btnLoadGaame";
            this.btnLoadGaame.Size = new System.Drawing.Size(183, 65);
            this.btnLoadGaame.TabIndex = 7;
            this.btnLoadGaame.Text = "Load Game";
            this.btnLoadGaame.UseVisualStyleBackColor = true;
            this.btnLoadGaame.Click += new System.EventHandler(this.btnLoadGaame_Click);
            // 
            // btnSavaGame
            // 
            this.btnSavaGame.Location = new System.Drawing.Point(560, 320);
            this.btnSavaGame.Name = "btnSavaGame";
            this.btnSavaGame.Size = new System.Drawing.Size(183, 68);
            this.btnSavaGame.TabIndex = 8;
            this.btnSavaGame.Text = "Save Game";
            this.btnSavaGame.UseVisualStyleBackColor = true;
            this.btnSavaGame.Click += new System.EventHandler(this.btnSavaGame_Click);
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 669);
            this.Controls.Add(this.btnSavaGame);
            this.Controls.Add(this.btnLoadGaame);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.TimerLeft);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.lbTotalPoints);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameplayForm";
            this.Text = "Aim Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameplayForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameplayForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTotalPoints;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startMenu;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Timer levelLength;
        private System.Windows.Forms.Label TimerLeft;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thinnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickToolStripMenuItem;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnLoadGaame;
        private System.Windows.Forms.Button btnSavaGame;
    }
}

