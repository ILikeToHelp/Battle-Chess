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
    public partial class UnitsPlayer2 : Form
    {
        public static int NoInf = 0;
        public static int NoSnip = 0;
        public static int NoMerc = 0;

        public UnitsPlayer2()
        {
            InitializeComponent();
        }

        private void UnitsPlayer2_Load(object sender, EventArgs e)
        {
            aGoldU2.Text = MultiplayerSetUp.Users2Gold.ToString();
            Player2Name.Text = MultiplayerSetUp.User2Name;
        }

        private void buyMercU2_Click(object sender, EventArgs e)
        {
            if (MultiplayerSetUp.Users2Gold >= 150)
            {
                NoMerc += 1;
                MultiplayerSetUp.Users2Gold = MultiplayerSetUp.Users2Gold - 150;
                aGoldU2.Text = MultiplayerSetUp.Users2Gold.ToString();
                cNMercU2.Text = NoMerc.ToString();
            }
        }
        private void buyInfU2_Click(object sender, EventArgs e)
        {
            if (MultiplayerSetUp.Users2Gold >= 250)
            {
                NoInf += 1;
                MultiplayerSetUp.Users2Gold = MultiplayerSetUp.Users2Gold - 250;
                aGoldU2.Text = MultiplayerSetUp.Users2Gold.ToString();
                cNInfU2.Text = NoInf.ToString();
            }
        }
        private void buySnipU2_Click(object sender, EventArgs e)
        {

            if (MultiplayerSetUp.Users2Gold >= 400)
            {
                NoSnip = NoSnip + 1;
                MainMenu.noSnip = NoSnip;
                MultiplayerSetUp.Users2Gold = MultiplayerSetUp.Users2Gold - 400;
                aGoldU2.Text = MultiplayerSetUp.Users2Gold.ToString();
                cNSnipU2.Text = NoSnip.ToString();
            }
        }

        private void toFieldMultip_Click(object sender, EventArgs e)
        {
            if (NoSnip != 0 || NoMerc != 0 || NoInf != 0)
            {
                this.Close();
                FieldMultiplayer Open = new FieldMultiplayer();
                Open.Show();
            }
            else
            {
                MessageBox.Show("Please buy any unit");
            }
        }

        

        

      

       
    }
}
