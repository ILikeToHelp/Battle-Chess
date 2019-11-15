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
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
        }
        int NoInf = MainMenu.noInf;
        int NoSnip = MainMenu.noSnip;
        int NoMerc = MainMenu.noMerc;
        private void Units_Load(object sender, EventArgs e)
        {
            //this part is responsible for setting amount of gold based on difficulty level
            aGold.Text = MainMenu.Gold.ToString();
            ///////////////////


            
        }


        private void buyInf_Click(object sender, EventArgs e)
        {
            
            if (MainMenu.Gold >= 250)
            {


                NoInf = NoInf + 1;
                MainMenu.noInf = NoInf;
                MainMenu.Gold = MainMenu.Gold - 250;
                aGold.Text = MainMenu.Gold.ToString();
                cNInf.Text = NoInf.ToString();
            }

        }

        private void buySnip_Click(object sender, EventArgs e)
        {
            if (MainMenu.Gold >= 400)
            {



                NoSnip = NoSnip + 1;
                MainMenu.noSnip = NoSnip;
                MainMenu.Gold = MainMenu.Gold - 400;
                aGold.Text = MainMenu.Gold.ToString();
                cNSnip.Text = NoSnip.ToString();
            }
        }

        private void buyMerc_Click(object sender, EventArgs e)
        {


            if (MainMenu.Gold >= 150)
            {



                NoMerc = NoMerc + 1;
                MainMenu.noMerc = NoMerc;
                MainMenu.Gold = MainMenu.Gold - 150;
                aGold.Text = MainMenu.Gold.ToString();
                cNMerc.Text = NoMerc.ToString();
            }
        }

        private void toField_Click(object sender, EventArgs e)
        {
            if (NoSnip!=0 || NoMerc!=0 || NoInf!=0)
            {
                this.Close();
                Field Open = new Field();
                Open.Show();  
            }
            else
            {
                MessageBox.Show("Please buy any unit");
            }
            
        }
    }
}