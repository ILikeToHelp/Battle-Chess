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
    public partial class UnitsPlayer1 : Form
    {
        public static int NoSnip = 0;
        public static int NoMerc=0;
        public static int NoInf=0;

        public UnitsPlayer1()
        {
            InitializeComponent();
        }

        private void UnitsPlayer1_Load(object sender, EventArgs e)
        {
            Player1Name.Text = MultiplayerSetUp.User1Name;
            aGoldU1.Text = MultiplayerSetUp.Users1Gold.ToString();
        }


        private void buyMercU1_Click(object sender, EventArgs e)
        {
            if (MultiplayerSetUp.Users1Gold >= 150)
            {
                NoMerc +=1;
                MultiplayerSetUp.Users1Gold = MultiplayerSetUp.Users1Gold - 150;
                aGoldU1.Text = MultiplayerSetUp.Users1Gold.ToString();
                cNMercU1.Text = NoMerc.ToString();
            }
        }

        private void buyInfU1_Click(object sender, EventArgs e)
        {
            if (MultiplayerSetUp.Users1Gold >= 250)
            {
                NoInf += 1;
                MultiplayerSetUp.Users1Gold = MultiplayerSetUp.Users1Gold - 250;
                aGoldU1.Text = MultiplayerSetUp.Users1Gold.ToString();
                cNInfU1.Text = NoInf.ToString();
            }
        }

        private void buySnipU1_Click(object sender, EventArgs e)
        {
            if (MultiplayerSetUp.Users1Gold >= 400)
            {
                NoSnip = NoSnip + 1;
                MainMenu.noSnip = NoSnip;
                MultiplayerSetUp.Users1Gold = MultiplayerSetUp.Users1Gold - 400;
                aGoldU1.Text = MultiplayerSetUp.Users1Gold.ToString();
                cNSnipU1.Text = NoSnip.ToString();
            }
        }

        private void toPlayer2Shop_Click(object sender, EventArgs e)
        {
            if (NoSnip != 0 || NoMerc != 0 || NoInf != 0)
            {
                this.Close();
                UnitsPlayer2 Open = new UnitsPlayer2();
                Open.Show();
            }
            else
            {
                MessageBox.Show("Please buy any unit");
            }
        }
    }   
}
