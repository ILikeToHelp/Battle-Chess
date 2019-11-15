namespace Game_1._1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Tutorial = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tutorial
            // 
            this.Tutorial.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.Location = new System.Drawing.Point(207, 123);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(438, 81);
            this.Tutorial.TabIndex = 16;
            this.Tutorial.Text = "Tutorial";
            this.Tutorial.UseVisualStyleBackColor = false;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(625, 632);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(215, 68);
            this.Quit.TabIndex = 15;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(207, 291);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(438, 75);
            this.Register.TabIndex = 14;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(207, 210);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(438, 75);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(207, 372);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(438, 75);
            this.Login.TabIndex = 12;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 752);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tutorial;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Login;
    }
}

