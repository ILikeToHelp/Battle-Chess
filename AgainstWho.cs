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
    public partial class AgainstWhom : Form
    {
        public AgainstWhom()
        {
            InitializeComponent();
        }

        

        private void AgainstWho_Load(object sender, EventArgs e)
        {

        }

        private void Single_Click(object sender, EventArgs e)
        {
            Difficulty c = new Difficulty();
            c.Show();
            this.Close();
        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {
            MultiplayerSetUp c = new MultiplayerSetUp();
            c.Show();
            this.Close();
        }

    }
}
