<<<<<<< HEAD
﻿using ManChoi;
using OOP_project;
=======
﻿using GameplayScreen;
>>>>>>> main
using System;

namespace MenuScreen
{
    public partial class Menu : Form
    {
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

        //====================MENU ELEMENTS====================
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Menu_Name(object sender, EventArgs e)
        {

        }
        private void Menu_PlayButton(object sender, EventArgs e)
        {
            SelectCharacter select = new SelectCharacter();
            select.Show();
            this.Hide();
        }

    }
}
