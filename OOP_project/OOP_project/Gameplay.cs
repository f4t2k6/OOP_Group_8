using System;
namespace ManChoi
{
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
        }
        //Generalproperties human = new Generalproperties("Palkia", 100);
        //Generalproperties bot = new Generalproperties("Dragon", 100);
        private int countX2dameitem = 0;
        private void Gameplay_Load(object sender, EventArgs e)
        {
            //human.currentHP = human.maxHP;
            //bot.currentHP = bot.maxHP;
            //HPhuman.Maximum = human.maxHP;
            //HPhuman.Value = human.maxHP;
            //HPBot.Value = bot.maxHP;
            //HPBot.Value = bot.maxHP;
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

        private void Spacial_Rend_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hydro_Pump_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countX2dameitem++;
            if (countX2dameitem <= 2)
            {

            }
            else
            {
                button3.Enabled = false;
            }
        }
    }
}
