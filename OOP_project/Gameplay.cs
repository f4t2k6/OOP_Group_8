using System;
using GeneralProperties;

namespace GameplayScreen
{
    public partial class Gameplay : Form
    {
        public Character Player1 { get; set; }
        public Character Player2 { get; set; }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
