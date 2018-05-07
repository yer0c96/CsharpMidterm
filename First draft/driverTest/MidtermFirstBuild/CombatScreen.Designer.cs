namespace MidtermFirstBuild
{
    partial class CombatScreen
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
            this.playerName = new System.Windows.Forms.Label();
            this.playerAttack = new System.Windows.Forms.Label();
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.enemyName = new System.Windows.Forms.Label();
            this.enemyAttack = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.depthCounter = new System.Windows.Forms.Label();
            this.goToInvetoryButton = new System.Windows.Forms.Button();
            this.combatGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.potion2Button = new System.Windows.Forms.Button();
            this.potion1Button = new System.Windows.Forms.Button();
            this.enemyDefense = new System.Windows.Forms.Label();
            this.playerDefense = new System.Windows.Forms.Label();
            this.combatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(106, 207);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(46, 17);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "label1";
            // 
            // playerAttack
            // 
            this.playerAttack.AutoSize = true;
            this.playerAttack.Location = new System.Drawing.Point(67, 267);
            this.playerAttack.Name = "playerAttack";
            this.playerAttack.Size = new System.Drawing.Size(46, 17);
            this.playerAttack.TabIndex = 1;
            this.playerAttack.Text = "label2";
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Location = new System.Drawing.Point(67, 238);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(46, 17);
            this.PlayerHealth.TabIndex = 2;
            this.PlayerHealth.Text = "label3";
            // 
            // enemyName
            // 
            this.enemyName.AutoSize = true;
            this.enemyName.Location = new System.Drawing.Point(696, 207);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(46, 17);
            this.enemyName.TabIndex = 3;
            this.enemyName.Text = "label1";
            // 
            // enemyAttack
            // 
            this.enemyAttack.AutoSize = true;
            this.enemyAttack.Location = new System.Drawing.Point(645, 267);
            this.enemyAttack.Name = "enemyAttack";
            this.enemyAttack.Size = new System.Drawing.Size(46, 17);
            this.enemyAttack.TabIndex = 4;
            this.enemyAttack.Text = "label2";
            // 
            // enemyHealth
            // 
            this.enemyHealth.AutoSize = true;
            this.enemyHealth.Location = new System.Drawing.Point(645, 238);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(46, 17);
            this.enemyHealth.TabIndex = 5;
            this.enemyHealth.Text = "label3";
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(109, 376);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(100, 80);
            this.attackButton.TabIndex = 6;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // depthCounter
            // 
            this.depthCounter.AutoSize = true;
            this.depthCounter.Location = new System.Drawing.Point(874, 376);
            this.depthCounter.Name = "depthCounter";
            this.depthCounter.Size = new System.Drawing.Size(46, 17);
            this.depthCounter.TabIndex = 7;
            this.depthCounter.Text = "label1";
            // 
            // goToInvetoryButton
            // 
            this.goToInvetoryButton.Location = new System.Drawing.Point(789, 488);
            this.goToInvetoryButton.Name = "goToInvetoryButton";
            this.goToInvetoryButton.Size = new System.Drawing.Size(131, 52);
            this.goToInvetoryButton.TabIndex = 8;
            this.goToInvetoryButton.Text = "Go to invetory";
            this.goToInvetoryButton.UseVisualStyleBackColor = true;
            this.goToInvetoryButton.Click += new System.EventHandler(this.goToInvetoryButton_Click);
            // 
            // combatGroupBox
            // 
            this.combatGroupBox.Controls.Add(this.label2);
            this.combatGroupBox.Controls.Add(this.label1);
            this.combatGroupBox.Controls.Add(this.potion2Button);
            this.combatGroupBox.Controls.Add(this.potion1Button);
            this.combatGroupBox.Controls.Add(this.enemyDefense);
            this.combatGroupBox.Controls.Add(this.playerDefense);
            this.combatGroupBox.Controls.Add(this.enemyName);
            this.combatGroupBox.Controls.Add(this.goToInvetoryButton);
            this.combatGroupBox.Controls.Add(this.playerName);
            this.combatGroupBox.Controls.Add(this.depthCounter);
            this.combatGroupBox.Controls.Add(this.playerAttack);
            this.combatGroupBox.Controls.Add(this.attackButton);
            this.combatGroupBox.Controls.Add(this.PlayerHealth);
            this.combatGroupBox.Controls.Add(this.enemyHealth);
            this.combatGroupBox.Controls.Add(this.enemyAttack);
            this.combatGroupBox.Location = new System.Drawing.Point(-6, -8);
            this.combatGroupBox.Name = "combatGroupBox";
            this.combatGroupBox.Size = new System.Drawing.Size(1015, 728);
            this.combatGroupBox.TabIndex = 9;
            this.combatGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Use potion 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Use potion 1";
            // 
            // potion2Button
            // 
            this.potion2Button.Location = new System.Drawing.Point(328, 376);
            this.potion2Button.Name = "potion2Button";
            this.potion2Button.Size = new System.Drawing.Size(100, 80);
            this.potion2Button.TabIndex = 12;
            this.potion2Button.Text = "button2";
            this.potion2Button.UseVisualStyleBackColor = true;
            this.potion2Button.Click += new System.EventHandler(this.potion2Button_Click);
            // 
            // potion1Button
            // 
            this.potion1Button.Location = new System.Drawing.Point(218, 376);
            this.potion1Button.Name = "potion1Button";
            this.potion1Button.Size = new System.Drawing.Size(100, 80);
            this.potion1Button.TabIndex = 11;
            this.potion1Button.Text = "button";
            this.potion1Button.UseVisualStyleBackColor = true;
            this.potion1Button.Click += new System.EventHandler(this.potion1Button_Click);
            // 
            // enemyDefense
            // 
            this.enemyDefense.AutoSize = true;
            this.enemyDefense.Location = new System.Drawing.Point(645, 302);
            this.enemyDefense.Name = "enemyDefense";
            this.enemyDefense.Size = new System.Drawing.Size(46, 17);
            this.enemyDefense.TabIndex = 10;
            this.enemyDefense.Text = "label1";
            // 
            // playerDefense
            // 
            this.playerDefense.AutoSize = true;
            this.playerDefense.Location = new System.Drawing.Point(67, 302);
            this.playerDefense.Name = "playerDefense";
            this.playerDefense.Size = new System.Drawing.Size(46, 17);
            this.playerDefense.TabIndex = 9;
            this.playerDefense.Text = "label1";
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combatGroupBox);
            this.Name = "CombatScreen";
            this.Size = new System.Drawing.Size(1000, 700);
            this.combatGroupBox.ResumeLayout(false);
            this.combatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label playerAttack;
        private System.Windows.Forms.Label PlayerHealth;
        private System.Windows.Forms.Label enemyName;
        private System.Windows.Forms.Label enemyAttack;
        private System.Windows.Forms.Label enemyHealth;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Label depthCounter;
        private System.Windows.Forms.Button goToInvetoryButton;
        private System.Windows.Forms.GroupBox combatGroupBox;
        private System.Windows.Forms.Label enemyDefense;
        private System.Windows.Forms.Label playerDefense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potion2Button;
        private System.Windows.Forms.Button potion1Button;
        private System.Windows.Forms.Label label2;
    }
}
