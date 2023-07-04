namespace AimLab
{
    partial class InputDialogForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 22);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your name, if you previously have used your name just try some nickn" +
    "ame or load your previous game.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearTextButton.Location = new System.Drawing.Point(339, 95);
            this.clearTextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(108, 28);
            this.clearTextButton.TabIndex = 3;
            this.clearTextButton.Text = "Clear text";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(225, 95);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(108, 28);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Use name";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 101);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 5;
            // 
            // InputDialogForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearTextButton;
            this.ClientSize = new System.Drawing.Size(459, 207);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InputDialogForm";
            this.Text = "Enter name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.TextBox textBox1;
    }
}