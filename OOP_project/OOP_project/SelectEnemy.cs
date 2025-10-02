using Gameplayscreen;
using ManChoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class SelectEnemy : Form
    {
        private Character Player;
        public Character Enemy { get; private set; }
        public SelectEnemy(Character player)
        {
            InitializeComponent();
            this.Player = player;
        }

        private void Poke2_Click(object sender, EventArgs e)
        {
            this.Enemy = new Character("Charizard", "Fire", 80, 35, 1000, 100, Properties.Resources.Charizard_enemy);
            Gameplay battle = new Gameplay(this.Player, this.Enemy);
            battle.Show();
            this.Hide();
        }

        private void Poke3_Click(object sender, EventArgs e)
        {

        }
    }
}
