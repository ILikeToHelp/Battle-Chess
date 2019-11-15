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
    public partial class MainMenu : Form
    {
        public static int Gold = 0;
        public static int noMerc = 0;
        public static int noInf = 0;
        public static int noSnip = 0;
        public static int EnemyGold = 0;
        public static bool win = false;

        public MainMenu()
        {
            InitializeComponent();
            Form Open = new Blank();
            Open.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Gold = 0;
            noMerc = 0;
            noInf = 0;
            noSnip = 0;
            EnemyGold = 0;
             win = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgainstWhom Open = new AgainstWhom();
            Open.Show();
            
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
