using Gameplayscreen;
using System;
namespace GameplayScreen
{
    public partial class Gameplay : Form
    {
        private Character player;
        private Character enemy;
        public Gameplay(Character p,Character e)
        {
            InitializeComponent();
<<<<<<< HEAD
            player = p;
            enemy = e;

            Player_name.Text=player._name;
            Player_HP.Maximum=player._maxhp;
            Player_HP.Value=player._maxhp;
            Pic_Player.Image = player.avatar;

            Enemy_name.Text =enemy._name;
            Enemy_HP.Maximum=enemy._maxhp;
            Enemy_HP.Value=enemy._maxhp;
            Pic_Enemy.Image =enemy.avatar;
        }
    
=======
            this.FormClosed += Gameplay_CloseProgram;
        }
        //Shut down entire program when close the form
        private void Gameplay_CloseProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
>>>>>>> main
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




<<<<<<< HEAD
        }

        private void Fusion_Bolt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Thunder_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bot_name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> main
    }
}
