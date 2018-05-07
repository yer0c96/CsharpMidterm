namespace MidtermFirstBuild
{
    partial class endScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deathScreenLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.endScreenGroupBox = new System.Windows.Forms.GroupBox();
            this.endScreenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deathScreenLabel
            // 
            this.deathScreenLabel.AutoSize = true;
            this.deathScreenLabel.Location = new System.Drawing.Point(88, 36);
            this.deathScreenLabel.Name = "deathScreenLabel";
            this.deathScreenLabel.Size = new System.Drawing.Size(74, 17);
            this.deathScreenLabel.TabIndex = 0;
            this.deathScreenLabel.Text = "YOU DIED";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(82, 129);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(94, 36);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // endScreenGroupBox
            // 
            this.endScreenGroupBox.Controls.Add(this.deathScreenLabel);
            this.endScreenGroupBox.Controls.Add(this.playAgainButton);
            this.endScreenGroupBox.Location = new System.Drawing.Point(126, 114);
            this.endScreenGroupBox.Name = "endScreenGroupBox";
            this.endScreenGroupBox.Size = new System.Drawing.Size(262, 200);
            this.endScreenGroupBox.TabIndex = 2;
            this.endScreenGroupBox.TabStop = false;
            // 
            // endScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endScreenGroupBox);
            this.Name = "endScreen";
            this.Size = new System.Drawing.Size(540, 495);
            this.endScreenGroupBox.ResumeLayout(false);
            this.endScreenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deathScreenLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.GroupBox endScreenGroupBox;
    }
}
