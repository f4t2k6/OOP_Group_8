using CharacterDataFile;
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
            player1_character.Image = CharacterData.Player1.avatar;
            player2_character.Image = CharacterData.Player2.avatar;
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
            player2_character.Image = CharacterData.Player2.avatar;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
