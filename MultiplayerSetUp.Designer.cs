namespace Game_1._1
{
    partial class MultiplayerSetUp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Player1Level = new System.Windows.Forms.ComboBox();
            this.Player2level = new System.Windows.Forms.ComboBox();
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Quit1 = new System.Windows.Forms.Button();
            this.StartFromMulti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(554, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Player1Level
            // 
            this.Player1Level.FormattingEnabled = true;
            this.Player1Level.Location = new System.Drawing.Point(99, 247);
            this.Player1Level.Name = "Player1Level";
            this.Player1Level.Size = new System.Drawing.Size(121, 21);
            this.Player1Level.TabIndex = 2;
            // 
            // Player2level
            // 
            this.Player2level.FormattingEnabled = true;
            this.Player2level.Location = new System.Drawing.Point(604, 247);
            this.Player2level.Name = "Player2level";
            this.Player2level.Size = new System.Drawing.Size(121, 21);
            this.Player2level.TabIndex = 3;
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.BackColor = System.Drawing.Color.SlateGray;
            this.Player1Name.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.ForeColor = System.Drawing.Color.Purple;
            this.Player1Name.Location = new System.Drawing.Point(26, 58);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(290, 31);
            this.Player1Name.TabIndex = 169;
            this.Player1Name.Text = "Choose Name for Player1 ";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.BackColor = System.Drawing.Color.SlateGray;
            this.Player2Name.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.ForeColor = System.Drawing.Color.Purple;
            this.Player2Name.Location = new System.Drawing.Point(496, 60);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(291, 31);
            this.Player2Name.TabIndex = 170;
            this.Player2Name.Text = "Choose Name for Player2";
            // 
            // Quit1
            // 
            this.Quit1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Quit1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit1.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit1.Location = new System.Drawing.Point(743, 636);
            this.Quit1.Name = "Quit1";
            this.Quit1.Size = new System.Drawing.Size(74, 41);
            this.Quit1.TabIndex = 171;
            this.Quit1.Text = "Quit";
            this.Quit1.UseVisualStyleBackColor = false;
            this.Quit1.Click += new System.EventHandler(this.Quit1_Click);
            // 
            // StartFromMulti
            // 
            this.StartFromMulti.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.StartFromMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartFromMulti.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFromMulti.Location = new System.Drawing.Point(195, 553);
            this.StartFromMulti.Name = "StartFromMulti";
            this.StartFromMulti.Size = new System.Drawing.Size(438, 81);
            this.StartFromMulti.TabIndex = 172;
            this.StartFromMulti.Text = "Start!";
            this.StartFromMulti.UseVisualStyleBackColor = false;
            this.StartFromMulti.Click += new System.EventHandler(this.StartFromMulti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(49, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 173;
            this.label1.Text = "Choose Level for  Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(535, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 174;
            this.label2.Text = "Choose Level for Player2";
            // 
            // MultiplayerSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_1._1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(839, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartFromMulti);
            this.Controls.Add(this.Quit1);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player2level);
            this.Controls.Add(this.Player1Level);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiplayerSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplayerSetUp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MultiplayerSetUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox Player1Level;
        private System.Windows.Forms.ComboBox Player2level;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Button Quit1;
        private System.Windows.Forms.Button StartFromMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}