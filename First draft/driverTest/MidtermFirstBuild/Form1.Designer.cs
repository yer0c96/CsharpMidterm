namespace MidtermFirstBuild
{
    partial class Form1
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
            this.playButton = new System.Windows.Forms.Button();
            this.mainMenuGroup = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(549, 653);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 100);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // mainMenuGroup
            // 
            this.mainMenuGroup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainMenuGroup.Controls.Add(this.pictureBox1);
            this.mainMenuGroup.Controls.Add(this.nameTextBox);
            this.mainMenuGroup.Controls.Add(this.label1);
            this.mainMenuGroup.Controls.Add(this.playButton);
            this.mainMenuGroup.Location = new System.Drawing.Point(-15, -15);
            this.mainMenuGroup.Name = "mainMenuGroup";
            this.mainMenuGroup.Size = new System.Drawing.Size(1300, 1000);
            this.mainMenuGroup.TabIndex = 2;
            this.mainMenuGroup.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(399, 590);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidtermFirstBuild.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(249, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 438);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.mainMenuGroup);
            this.Name = "Form1";
            this.Text = "Form2";
            this.mainMenuGroup.ResumeLayout(false);
            this.mainMenuGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.GroupBox mainMenuGroup;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}