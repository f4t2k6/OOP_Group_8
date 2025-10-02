using Gameplayscreen;
using ManChoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class SelectCharacter : Form
    {
        public FireClass Firechar { get; private set; }
        public WaterClass Waterchar { get; private set; }
        public SelectCharacter()
        {
            InitializeComponent();
        }

        private void SelectCharacter_Load(object sender, EventArgs e)
        {

        }

        private void Poke2_Click(object sender, EventArgs e)
        {
            this.Firechar = new FireClass("Charizard", "Fire", 80, 35, 1000, 100, Properties.Resources.Charizard_player, 50);
            SelectEnemy select = new SelectEnemy(this.Firechar);
            select.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Poke3_Click(object sender, EventArgs e)
        {
            this.Waterchar=new WaterClass("Palkia","Water",70,45,1000,100,Properties.Resources.Palkia_player, 50);
            SelectEnemy select =new SelectEnemy(this.Waterchar);
        }

        private void Poke1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Poke4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
