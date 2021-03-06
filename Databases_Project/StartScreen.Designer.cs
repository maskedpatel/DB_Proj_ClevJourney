﻿namespace Databases_Project
{
    partial class StartScreen
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
            this.NewPlayerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ResumePlayerButton = new System.Windows.Forms.Button();
            this.NewPlayerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectPlayerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPlayerButton
            // 
            this.NewPlayerButton.Location = new System.Drawing.Point(21, 146);
            this.NewPlayerButton.Name = "NewPlayerButton";
            this.NewPlayerButton.Size = new System.Drawing.Size(169, 37);
            this.NewPlayerButton.TabIndex = 1;
            this.NewPlayerButton.Text = "New Game";
            this.NewPlayerButton.UseVisualStyleBackColor = true;
            this.NewPlayerButton.Click += new System.EventHandler(this.NewPlayerButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ResumePlayerButton
            // 
            this.ResumePlayerButton.Location = new System.Drawing.Point(21, 197);
            this.ResumePlayerButton.Name = "ResumePlayerButton";
            this.ResumePlayerButton.Size = new System.Drawing.Size(169, 37);
            this.ResumePlayerButton.TabIndex = 3;
            this.ResumePlayerButton.Text = "Resume Game";
            this.ResumePlayerButton.UseVisualStyleBackColor = true;
            this.ResumePlayerButton.Click += new System.EventHandler(this.ResumePlayerButton_Click);
            // 
            // NewPlayerTextBox
            // 
            this.NewPlayerTextBox.Location = new System.Drawing.Point(211, 161);
            this.NewPlayerTextBox.Name = "NewPlayerTextBox";
            this.NewPlayerTextBox.Size = new System.Drawing.Size(170, 22);
            this.NewPlayerTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Player Name:";
            // 
            // SelectPlayerComboBox
            // 
            this.SelectPlayerComboBox.FormattingEnabled = true;
            this.SelectPlayerComboBox.Location = new System.Drawing.Point(211, 210);
            this.SelectPlayerComboBox.Name = "SelectPlayerComboBox";
            this.SelectPlayerComboBox.Size = new System.Drawing.Size(170, 24);
            this.SelectPlayerComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Previous Player Name:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(19, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(388, 84);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Cleveland Trail";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.ForeColor = System.Drawing.Color.Red;
            this.deletePlayerButton.Location = new System.Drawing.Point(305, 247);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlayerButton.TabIndex = 10;
            this.deletePlayerButton.Text = "Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.deletePlayerButton_Click);
            // 
            // StartScreen
            // 
            this.AccessibleName = "";
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(419, 331);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectPlayerComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPlayerTextBox);
            this.Controls.Add(this.ResumePlayerButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewPlayerButton);
            this.Name = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewPlayerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ResumePlayerButton;
        private System.Windows.Forms.TextBox NewPlayerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.ComboBox SelectPlayerComboBox;
        private System.Windows.Forms.Button deletePlayerButton;
    }
}

