using Gameplayscreen;
using System;
namespace ManChoi
{
    public partial class Gameplay : Form
    {
        private Character player;
        private Character enemy;
        public Gameplay(Character p,Character e)
        {
            InitializeComponent();
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
    
        private void Gameplay_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void HPhuman_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
