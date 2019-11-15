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
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {

        }

        private void Easy_Click(object sender, EventArgs e)
        {
            MainMenu.EnemyGold = 1000;
            MainMenu.Gold = 2000;
            this.Close();
            Units f1 = new Units();
            f1.Show();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            MainMenu.EnemyGold = 1500;
            MainMenu.Gold = 1500;
            this.Close();
            Units f1 = new Units();
            f1.Show();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            MainMenu.EnemyGold = 2000;
            MainMenu.Gold = 1000;
            this.Close();
            Units f1 = new Units();
            f1.Show();
        }

        private void Insane_Click(object sender, EventArgs e)
        {
            MainMenu.EnemyGold = 2000;
            MainMenu.Gold = 500;
            this.Close();
            Units f1 = new Units();
            f1.Show();
        }

        private void Quit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
