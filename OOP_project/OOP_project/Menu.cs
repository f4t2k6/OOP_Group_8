using ManChoi;
using OOP_project;
using System;

namespace ManHinhChinh
{
    public partial class Menu : Form
    {
        //khởi tạo form Menu
        public Menu()
        {
            InitializeComponent();
        }

        //load form Menu
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Hình ảnh tên game
        private void Pic_TenGame(object sender, EventArgs e)
        {

        }

        //Nút Play
        private void Button_Play(object sender, EventArgs e)
        {
            SelectCharacter select = new SelectCharacter();
            select.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
