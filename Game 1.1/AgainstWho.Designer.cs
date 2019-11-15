namespace Game_1._1
{
    partial class AgainstWhom
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
            this.Single = new System.Windows.Forms.Button();
            this.Multiplayer = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Single
            // 
            this.Single.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Single.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single.Location = new System.Drawing.Point(171, 189);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(438, 81);
            this.Single.TabIndex = 18;
            this.Single.Text = "Single Player";
            this.Single.UseVisualStyleBackColor = false;
            this.Single.Click += new System.EventHandler(this.Single_Click);
            // 
            // Multiplayer
            // 
            this.Multiplayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplayer.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer.Location = new System.Drawing.Point(171, 352);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(438, 75);
            this.Multiplayer.TabIndex = 17;
            this.Multiplayer.Text = "Hot Seat";
            this.Multiplayer.UseVisualStyleBackColor = false;
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Poor Richard", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(592, 589);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(215, 68);
            this.Quit.TabIndex = 19;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            // 
            // AgainstWhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_1._1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(839, 689);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Single);
            this.Controls.Add(this.Multiplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgainstWhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgainstWho";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgainstWho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Single;
        private System.Windows.Forms.Button Multiplayer;
        private System.Windows.Forms.Button Quit;

    }
}