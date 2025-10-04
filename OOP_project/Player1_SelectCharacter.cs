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
    public partial class player1_selectwindow : Form
    {
        //====================DEFAULTS====================
        public player1_selectwindow()
        {
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
        private void Player1_Choosed()
        {
            player2_selectwindow player2_selectcharacterscreen = new player2_selectwindow();
            player2_selectcharacterscreen.Show();
            this.Hide();
        }
        private void PLayer1_Notify(object sender, EventArgs e)
        {

        }
        private void drapion_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player1 = new Character("Drapion", "Poison", 85, 80, 800, 90,
                OOP_project.Properties.Resources.drapion_p1);
            Player1_Choosed();
        }

        private void charizard_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player1 = new Character("Charizard", "Fire", 110, 60, 750, 120,
                OOP_project.Properties.Resources.charizard_p1);
            Player1_Choosed();
        }

        private void palkia_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player1 = new Character("Palkia", "Water", 120, 75, 1000, 160,
                OOP_project.Properties.Resources.palkia_p1);
            Player1_Choosed();
        }

        private void zekrom_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player1 = new Character("Zekrom", "Electric", 130, 70, 950, 140,
                OOP_project.Properties.Resources.zekrom_p1);
            Player1_Choosed();
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
    }
}
