namespace Game_1._1
{
    partial class endGameScreen
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
            this.goBackMainMenu = new System.Windows.Forms.Button();
            this.closeGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackMainMenu
            // 
            this.goBackMainMenu.Location = new System.Drawing.Point(169, 391);
            this.goBackMainMenu.Name = "goBackMainMenu";
            this.goBackMainMenu.Size = new System.Drawing.Size(340, 72);
            this.goBackMainMenu.TabIndex = 3;
            this.goBackMainMenu.Text = "Main Menu";
            this.goBackMainMenu.UseVisualStyleBackColor = true;
            this.goBackMainMenu.Click += new System.EventHandler(this.goBackMainMenu_Click);
            // 
            // closeGame
            // 
            this.closeGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeGame.Location = new System.Drawing.Point(244, 469);
            this.closeGame.Name = "closeGame";
            this.closeGame.Size = new System.Drawing.Size(201, 42);
            this.closeGame.TabIndex = 2;
            this.closeGame.Text = "EXIT";
            this.closeGame.UseVisualStyleBackColor = true;
            this.closeGame.Click += new System.EventHandler(this.closeGame_Click);
            // 
            // endGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(691, 564);
            this.Controls.Add(this.goBackMainMenu);
            this.Controls.Add(this.closeGame);
            this.Name = "endGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "endGameScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.endGameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBackMainMenu;
        private System.Windows.Forms.Button closeGame;
    }
}