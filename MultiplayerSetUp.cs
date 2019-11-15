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
    public partial class MultiplayerSetUp : Form
    {
        public static string User1Name = "";
        public static string User2Name = "";
        bool g = false;
        public static int Users1Gold = 0;
        public static int Users2Gold = 0;

        public MultiplayerSetUp()
        {
            InitializeComponent();
        }

        private void MultiplayerSetUp_Load(object sender, EventArgs e)
        {
            Player1Level.Items.Add("Easy");
            Player1Level.Items.Add("Medium");
            Player1Level.Items.Add("Hard");
            Player1Level.Items.Add("Insane");


            Player2level.Items.Add("Easy");
            Player2level.Items.Add("Medium");
            Player2level.Items.Add("Hard");
            Player2level.Items.Add("Insane");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            User1Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            User2Name = textBox2.Text;
        }

        private void StartFromMulti_Click(object sender, EventArgs e)
        {
            if (Player2level.Text != "" && Player1Level.Text != "")
            {
                switch (Player1Level.Text)
                {
                    case "Easy":
                        Users1Gold = 2000;
                        g = true;
                        break;
                    case "Medium":
                        Users1Gold = 1500;
                        g = true;
                        break;
                    case "Hard":
                        Users1Gold = 1000;
                        g = true;
                        break;
                    case "Insane":
                        Users1Gold = 500;
                        g = true;
                        break;
                }
                switch (Player2level.Text)
                {
                    case "Easy":
                        Users2Gold = 2000;
                        g = true;
                        break;
                    case "Medium":
                        Users2Gold = 1500;
                        g = true;
                        break;
                    case "Hard":
                        Users2Gold = 1000;
                        g = true;
                        break;
                    case "Insane":
                        Users2Gold = 500;
                        g = true;
                        break;
          

            
                }

                //UnitsPlayer1 c = new UnitsPlayer1();
                //c.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Choose difficulty before starting the game");
            }


            if (g)
            {
                UnitsPlayer1 c = new UnitsPlayer1();
            c.Show();
            this.Close();
            }

        
        
        }

       

        private void Quit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
