using GeneralProperties;
using OOP_project.Properties;
using System;

namespace GameplayScreen
{

    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
            this.FormClosed += Gameplay_CloseProgram;
        }
        //Shut down entire program when close the form
        private void Gameplay_CloseProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Gameplay_Load(object sender, EventArgs e)
        {
            //p1
            player1_character.Image = CharacterData.Player1._avatar;
            player1_name.Text = CharacterData.Player1._name;
            player1_hp.Minimum = 0;
            player1_hp.Maximum = CharacterData.Player1._maxhp;
            player1_hp.Value = CharacterData.Player1._currenthp;
            player1_mana.Minimum = 0;
            player1_mana.Maximum = CharacterData.Player1._maxmana;
            player1_mana.Value = CharacterData.Player1._currentmana;

            //p2
            player2_character.Image = CharacterData.Player2._avatar;
            player2_name.Text = CharacterData.Player2._name;
            player2_hp.Minimum = 0;
            player2_hp.Maximum = CharacterData.Player2._maxhp;
            player2_hp.Value = CharacterData.Player2._currenthp;
            player2_mana.Minimum = 0;
            player2_mana.Maximum = CharacterData.Player2._maxmana;
            player2_mana.Value = CharacterData.Player2._currentmana;
        }
        private void BackgroundPic(object sender, EventArgs e)
        {

        }
        //====================PLAYER 1====================
        private void Player1_Character(object sender, EventArgs e)
        {

        }
        private void Player1_Name(object sender, EventArgs e)
        {

        }
        private void Player1_HP(object sender, EventArgs e)
        {

        }
        private void Player1_NormalAttack(object sender, EventArgs e)
        {

        }
        private void Player1_SpecialAttack(object sender, EventArgs e)
        {

        }
        private void Player1_DefBoost(object sender, EventArgs e)
        {

        }
        //====================PLAYER 2====================
        private void Player2_Character(object sender, EventArgs e)
        {
        }
        private void Player2_Name(object sender, EventArgs e)
        {

        }
        private void Player2_HP(object sender, EventArgs e)
        {

        }
        private void Player2_NormalAttack(object sender, EventArgs e)
        {

        }
        private void Player2_SpecialAttack(object sender, EventArgs e)
        {

        }
        private void Player2_DefBoost(object sender, EventArgs e)
        {
        }

        private void TextBox(object sender, EventArgs e)
        {

        }

        private void Player1_Mana(object sender, EventArgs e)
        {

        }

        private void Player2_Mana(object sender, EventArgs e)
        {

        }
    }
}
