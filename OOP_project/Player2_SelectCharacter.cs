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
using Player1_SelectCharacterScreen;

namespace Player2_SelectCharacterScreen
{
    public partial class player2_selectwindow : Form
    {
        //====================DEFAULTS====================
        public player2_selectwindow()
        {
            InitializeComponent();
            this.FormClosed += Player2SelectCloseProgram;
        }

        private void Player2SelectCloseProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Player2_SelectCharacter_Load(object sender, EventArgs e)
        {

        }
        //====================ELEMENTS====================
        private void Player2_Notify(object sender, EventArgs e)
        {

        }
        private void Player2_Choosed()
        {
            Gameplay gameplayscreen = new Gameplay();
            gameplayscreen.Show();
            this.Hide();
        }
        private void drapion_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player2 = new PoisonClass("Drapion", "Poison", 70, 90, 800, 80, 15,
                OOP_project.Properties.Resources.drapion_p2, 40);
            Player2_Choosed();
        }

        private void charizard_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player2 = new FireClass("Charizard", "Fire", 100, 70, 750, 120, 15,
                OOP_project.Properties.Resources.charizard_p2,10);
            Player2_Choosed();
        }

        private void palkia_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player2 = new WaterClass("Palkia", "Water", 130, 110, 1000, 180, 15,
                OOP_project.Properties.Resources.palkia_p2,80);
            Player2_Choosed();
        }

        private void zekrom_button_Click(object sender, EventArgs e)
        {
            CharacterData.Player2 = new ElectricClass("Zekrom", "Electric", 140, 100, 950, 170, 15,
                OOP_project.Properties.Resources.zekrom_p2, false);
            Player2_Choosed();
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
