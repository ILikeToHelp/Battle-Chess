namespace Game_1._1
{
    partial class Difficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Difficulty));
            this.Quit1 = new System.Windows.Forms.Button();
            this.Insane = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Quit1
            // 
            this.Quit1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Quit1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit1.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit1.Location = new System.Drawing.Point(316, 510);
            this.Quit1.Name = "Quit1";
            this.Quit1.Size = new System.Drawing.Size(137, 41);
            this.Quit1.TabIndex = 14;
            this.Quit1.Text = "Quit";
            this.Quit1.UseVisualStyleBackColor = false;
            this.Quit1.Click += new System.EventHandler(this.Quit1_Click);
            // 
            // Insane
            // 
            this.Insane.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Insane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Insane.BackgroundImage")));
            this.Insane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Insane.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Insane.ForeColor = System.Drawing.Color.Lavender;
            this.Insane.Location = new System.Drawing.Point(283, 382);
            this.Insane.Name = "Insane";
            this.Insane.Size = new System.Drawing.Size(213, 126);
            this.Insane.TabIndex = 13;
            this.Insane.UseVisualStyleBackColor = false;
            this.Insane.Click += new System.EventHandler(this.Insane_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Hard.Font = new System.Drawing.Font("Poor Richard", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.Location = new System.Drawing.Point(230, 280);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(318, 54);
            this.Hard.TabIndex = 12;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Medium
            // 
            this.Medium.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Medium.Font = new System.Drawing.Font("Poor Richard", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.Location = new System.Drawing.Point(168, 155);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(438, 77);
            this.Medium.TabIndex = 11;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = false;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Easy.Font = new System.Drawing.Font("Poor Richard", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.Location = new System.Drawing.Point(98, 48);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(584, 101);
            this.Easy.TabIndex = 10;
            this.Easy.Text = "Easy ";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(328, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "INSANE";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quit1);
            this.Controls.Add(this.Insane);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quit1;
        private System.Windows.Forms.Button Insane;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Label label1;
    }
}