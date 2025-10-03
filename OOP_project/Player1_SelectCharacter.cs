using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameplayScreen;
using GeneralProperties;
using Player2_SelectCharacterScreen;

namespace Player1_SelectCharacterScreen
{
    public partial class Player1_SelectCharacter : Form
    {
        //====================DEFAULTS====================
        public Player1_SelectCharacter()
        {
            Gameplay gp = new Gameplay();
            gp.Player1 = new Character();
            InitializeComponent();
            this.FormClosed += Player1SelectCloseProgram;
        }

        private void Player1SelectCloseProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Player1_SelectCharacter_Load(object sender, EventArgs e)
        {

        }
        //====================ELEMENTS====================
        private void Player1_Choosed(object sender, EventArgs e)
        {
            Player2_SelectCharacter player2_selectcharacterscreen = new Player2_SelectCharacter();
            player2_selectcharacterscreen.Show();
            this.Hide();
        }
        private void PLayer1_Notify(object sender, EventArgs e)
        {

        }

        private void poison_core_Click(object sender, EventArgs e)
        {

        }

        private void fire_core_Click(object sender, EventArgs e)
        {

        }

        private void water_core_Click(object sender, EventArgs e)
        {

        }

        private void electric_core_Click(object sender, EventArgs e)
        {

        }

        private void drapion_button_Click(object sender, EventArgs e)
        {

        }

        private void charizard_button_Click(object sender, EventArgs e)
        {

        }

        private void palkia_button_Click(object sender, EventArgs e)
        {

        }

        private void zekrom_button_Click(object sender, EventArgs e)
        {

        }
    }
}
