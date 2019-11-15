using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_1._1
{
    public partial class endGameScreen : Form
    {
        public endGameScreen()
        {
            InitializeComponent();
        }
        string filePath = Application.StartupPath;
        private void endGameScreen_Load(object sender, EventArgs e)
        {
            UnitsPlayer1.NoMerc = 0;
            UnitsPlayer1.NoInf = 0;
            UnitsPlayer1.NoSnip = 0;

            UnitsPlayer2.NoMerc = 0;
            UnitsPlayer2.NoInf = 0;
            UnitsPlayer2.NoSnip = 0;

            if (MainMenu.win == true)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(filePath + "\\pics\\you win.jpg");
            }
            else
            {
                this.BackgroundImageLayout = ImageLayout.Tile;
                this.BackgroundImage = System.Drawing.Image.FromFile(filePath + "\\pics\\you lose.jpg");
            }

        }

        private void goBackMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu Open = new MainMenu();
            Open.Show();
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
