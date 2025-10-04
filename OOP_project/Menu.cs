using System;
using Player1_SelectCharacterScreen;

namespace MenuScreen
{
    public partial class Menu : Form
    {
        //====================DEFAULTS====================
        public Menu()
        {
            InitializeComponent();
            this.FormClosed += Menu_CloseProgram;
        }
        //Shut down entire program when close the form
        private void Menu_CloseProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        //====================ELEMENTS====================
        private void Menu_PlayButton(object sender, EventArgs e)
        {
            player1_selectwindow player1_selectcharacterscreen = new player1_selectwindow();
            player1_selectcharacterscreen.Show();
            this.Hide();
        }
    }
}
