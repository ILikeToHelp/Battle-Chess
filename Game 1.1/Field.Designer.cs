namespace Game_1._1
{
    partial class Field
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnoS = new System.Windows.Forms.Label();
            this.lbnoI = new System.Windows.Forms.Label();
            this.lbnoM = new System.Windows.Forms.Label();
            this.depSnip = new System.Windows.Forms.Button();
            this.depInf = new System.Windows.Forms.Button();
            this.depMerc = new System.Windows.Forms.Button();
            this.lbSnip = new System.Windows.Forms.Label();
            this.lbInf = new System.Windows.Forms.Label();
            this.lbMe = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Moves = new System.Windows.Forms.RichTextBox();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.skipTurn = new System.Windows.Forms.Button();
            this.specialAbility = new System.Windows.Forms.Button();
            this.Movement = new System.Windows.Forms.Button();
            this.Shot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.descriptiveLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pastMoves = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Loading = new System.Windows.Forms.ToolStripMenuItem();
            this.Saving = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lbnoS);
            this.panel1.Controls.Add(this.lbnoI);
            this.panel1.Controls.Add(this.lbnoM);
            this.panel1.Controls.Add(this.depSnip);
            this.panel1.Controls.Add(this.depInf);
            this.panel1.Controls.Add(this.depMerc);
            this.panel1.Controls.Add(this.lbSnip);
            this.panel1.Controls.Add(this.lbInf);
            this.panel1.Controls.Add(this.lbMe);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 257);
            this.panel1.TabIndex = 165;
            // 
            // lbnoS
            // 
            this.lbnoS.AutoSize = true;
            this.lbnoS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbnoS.ForeColor = System.Drawing.Color.Red;
            this.lbnoS.Location = new System.Drawing.Point(533, 93);
            this.lbnoS.Name = "lbnoS";
            this.lbnoS.Size = new System.Drawing.Size(16, 18);
            this.lbnoS.TabIndex = 161;
            this.lbnoS.Text = "x";
            // 
            // lbnoI
            // 
            this.lbnoI.AutoSize = true;
            this.lbnoI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbnoI.ForeColor = System.Drawing.Color.Red;
            this.lbnoI.Location = new System.Drawing.Point(326, 91);
            this.lbnoI.Name = "lbnoI";
            this.lbnoI.Size = new System.Drawing.Size(16, 18);
            this.lbnoI.TabIndex = 160;
            this.lbnoI.Text = "x";
            // 
            // lbnoM
            // 
            this.lbnoM.AutoSize = true;
            this.lbnoM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbnoM.ForeColor = System.Drawing.Color.Red;
            this.lbnoM.Location = new System.Drawing.Point(114, 93);
            this.lbnoM.Name = "lbnoM";
            this.lbnoM.Size = new System.Drawing.Size(16, 18);
            this.lbnoM.TabIndex = 159;
            this.lbnoM.Text = "x";
            // 
            // depSnip
            // 
            this.depSnip.AutoSize = true;
            this.depSnip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depSnip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.depSnip.Image = ((System.Drawing.Image)(resources.GetObject("depSnip.Image")));
            this.depSnip.Location = new System.Drawing.Point(444, 179);
            this.depSnip.Margin = new System.Windows.Forms.Padding(0);
            this.depSnip.Name = "depSnip";
            this.depSnip.Size = new System.Drawing.Size(80, 63);
            this.depSnip.TabIndex = 158;
            this.depSnip.Text = "Deploy!";
            this.depSnip.UseVisualStyleBackColor = true;
            this.depSnip.Click += new System.EventHandler(this.depSnip_Click);
            // 
            // depInf
            // 
            this.depInf.AutoSize = true;
            this.depInf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depInf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.depInf.Image = ((System.Drawing.Image)(resources.GetObject("depInf.Image")));
            this.depInf.Location = new System.Drawing.Point(233, 179);
            this.depInf.Margin = new System.Windows.Forms.Padding(0);
            this.depInf.Name = "depInf";
            this.depInf.Size = new System.Drawing.Size(80, 63);
            this.depInf.TabIndex = 157;
            this.depInf.Text = "Deploy!";
            this.depInf.UseVisualStyleBackColor = true;
            this.depInf.Click += new System.EventHandler(this.depInf_Click);
            // 
            // depMerc
            // 
            this.depMerc.AutoSize = true;
            this.depMerc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depMerc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.depMerc.Image = ((System.Drawing.Image)(resources.GetObject("depMerc.Image")));
            this.depMerc.Location = new System.Drawing.Point(17, 179);
            this.depMerc.Margin = new System.Windows.Forms.Padding(0);
            this.depMerc.Name = "depMerc";
            this.depMerc.Size = new System.Drawing.Size(80, 63);
            this.depMerc.TabIndex = 156;
            this.depMerc.Text = "Deploy!";
            this.depMerc.UseVisualStyleBackColor = true;
            this.depMerc.Click += new System.EventHandler(this.depMerc_Click);
            // 
            // lbSnip
            // 
            this.lbSnip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSnip.ForeColor = System.Drawing.Color.Purple;
            this.lbSnip.Location = new System.Drawing.Point(419, 93);
            this.lbSnip.Name = "lbSnip";
            this.lbSnip.Size = new System.Drawing.Size(163, 53);
            this.lbSnip.TabIndex = 155;
            this.lbSnip.Text = "You still have \r\nSnipers to deploy";
            // 
            // lbInf
            // 
            this.lbInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInf.ForeColor = System.Drawing.Color.Purple;
            this.lbInf.Location = new System.Drawing.Point(205, 91);
            this.lbInf.Name = "lbInf";
            this.lbInf.Size = new System.Drawing.Size(157, 53);
            this.lbInf.TabIndex = 154;
            this.lbInf.Text = "You still have \r\nInfantry soldiers to deploy";
            // 
            // lbMe
            // 
            this.lbMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMe.ForeColor = System.Drawing.Color.Purple;
            this.lbMe.Location = new System.Drawing.Point(0, 91);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(174, 65);
            this.lbMe.TabIndex = 153;
            this.lbMe.Text = "You still have \r\nMercenaries to deploy\r\n\r\n";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(423, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 76);
            this.button4.TabIndex = 152;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(17, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 76);
            this.button3.TabIndex = 151;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(209, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 76);
            this.button2.TabIndex = 150;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Moves
            // 
            this.Moves.ForeColor = System.Drawing.Color.Purple;
            this.Moves.Location = new System.Drawing.Point(634, 56);
            this.Moves.Name = "Moves";
            this.Moves.Size = new System.Drawing.Size(209, 183);
            this.Moves.TabIndex = 167;
            this.Moves.Text = "";
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.SlateGray;
            this.actionPanel.Controls.Add(this.skipTurn);
            this.actionPanel.Controls.Add(this.specialAbility);
            this.actionPanel.Controls.Add(this.Movement);
            this.actionPanel.Controls.Add(this.Shot);
            this.actionPanel.Controls.Add(this.label4);
            this.actionPanel.Controls.Add(this.label3);
            this.actionPanel.Controls.Add(this.label2);
            this.actionPanel.Controls.Add(this.label1);
            this.actionPanel.Location = new System.Drawing.Point(12, 598);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(616, 118);
            this.actionPanel.TabIndex = 166;
            this.actionPanel.Visible = false;
            // 
            // skipTurn
            // 
            this.skipTurn.Image = ((System.Drawing.Image)(resources.GetObject("skipTurn.Image")));
            this.skipTurn.Location = new System.Drawing.Point(493, 19);
            this.skipTurn.Name = "skipTurn";
            this.skipTurn.Size = new System.Drawing.Size(56, 56);
            this.skipTurn.TabIndex = 166;
            this.skipTurn.UseVisualStyleBackColor = true;
            this.skipTurn.Click += new System.EventHandler(this.skipTurn_Click);
            // 
            // specialAbility
            // 
            this.specialAbility.Enabled = false;
            this.specialAbility.Image = ((System.Drawing.Image)(resources.GetObject("specialAbility.Image")));
            this.specialAbility.Location = new System.Drawing.Point(329, 19);
            this.specialAbility.Name = "specialAbility";
            this.specialAbility.Size = new System.Drawing.Size(56, 56);
            this.specialAbility.TabIndex = 165;
            this.specialAbility.UseVisualStyleBackColor = true;
            this.specialAbility.Click += new System.EventHandler(this.specialAbility_Click);
            // 
            // Movement
            // 
            this.Movement.Image = ((System.Drawing.Image)(resources.GetObject("Movement.Image")));
            this.Movement.Location = new System.Drawing.Point(177, 19);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(56, 56);
            this.Movement.TabIndex = 164;
            this.Movement.UseVisualStyleBackColor = true;
            this.Movement.Click += new System.EventHandler(this.Movement_Click);
            // 
            // Shot
            // 
            this.Shot.Image = ((System.Drawing.Image)(resources.GetObject("Shot.Image")));
            this.Shot.Location = new System.Drawing.Point(30, 19);
            this.Shot.Name = "Shot";
            this.Shot.Size = new System.Drawing.Size(56, 56);
            this.Shot.TabIndex = 163;
            this.Shot.UseVisualStyleBackColor = true;
            this.Shot.Click += new System.EventHandler(this.Shot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(484, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 161;
            this.label4.Text = "Skip Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(305, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 160;
            this.label3.Text = "Special Ability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(164, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 159;
            this.label2.Text = "Movement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 158;
            this.label1.Text = "Shoot";
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(721, 673);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(122, 43);
            this.Quit.TabIndex = 164;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // descriptiveLabel
            // 
            this.descriptiveLabel.AutoSize = true;
            this.descriptiveLabel.BackColor = System.Drawing.Color.SlateGray;
            this.descriptiveLabel.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiveLabel.ForeColor = System.Drawing.Color.Purple;
            this.descriptiveLabel.Location = new System.Drawing.Point(644, 9);
            this.descriptiveLabel.Name = "descriptiveLabel";
            this.descriptiveLabel.Size = new System.Drawing.Size(190, 44);
            this.descriptiveLabel.TabIndex = 168;
            this.descriptiveLabel.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(644, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 44);
            this.label5.TabIndex = 169;
            this.label5.Text = "Past Moves";
            // 
            // pastMoves
            // 
            this.pastMoves.ForeColor = System.Drawing.Color.Purple;
            this.pastMoves.Location = new System.Drawing.Point(634, 315);
            this.pastMoves.Name = "pastMoves";
            this.pastMoves.Size = new System.Drawing.Size(209, 329);
            this.pastMoves.TabIndex = 170;
            this.pastMoves.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 171;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Loading,
            this.Saving,
            this.Exit});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // Loading
            // 
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(100, 22);
            this.Loading.Text = "Load";
            // 
            // Saving
            // 
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(100, 22);
            this.Saving.Text = "Save";
            this.Saving.Click += new System.EventHandler(this.Saving_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 728);
            this.Controls.Add(this.pastMoves);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptiveLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Moves);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Field";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Field_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnoS;
        private System.Windows.Forms.Label lbnoI;
        private System.Windows.Forms.Label lbnoM;
        private System.Windows.Forms.Button depSnip;
        private System.Windows.Forms.Button depInf;
        private System.Windows.Forms.Button depMerc;
        private System.Windows.Forms.Label lbSnip;
        private System.Windows.Forms.Label lbInf;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Moves;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button skipTurn;
        private System.Windows.Forms.Button specialAbility;
        private System.Windows.Forms.Button Movement;
        private System.Windows.Forms.Button Shot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label descriptiveLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox pastMoves;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Loading;
        private System.Windows.Forms.ToolStripMenuItem Saving;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}