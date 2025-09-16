/*
Các thuộc tính:
- Pic_TenGame: Picture Box
 */
using OOP_project;
using System;

namespace oop_group8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pic_TenGame(object sender, EventArgs e)
        {

        }

        private void Button_Play(object sender, EventArgs e)
        {
            Gameplay gameplay = new Gameplay();

            gameplay.Show();

            this.Hide();
        }

    }
}
