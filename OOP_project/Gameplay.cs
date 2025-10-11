using GeneralProperties;
using OOP_project.Properties;
using System;
//===============CÁC LỖI CẦN FIX==========================
// Lỗi thuộc tính tê liệt của hệ điện (chưa build xong vì phải build lại toàn bộ thuộc tính enable các nút khi bị tê liệt)
// Cần tạo ra rest màn khi 1 bên hết máu 
// combat mà player1 đi trước mà vẫn bị player2 đấm hẹo trước (15 lần test)

namespace GameplayScreen
{

    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
            this.FormClosed += Gameplay_CloseProgram;
        }

        private const int SpecialAttackCost = 30;
        private const int BoostDefCost = 15;
        private bool P1turn = true;
        //Shut down entire program when close the form
        private void Gameplay_CloseProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Gameplay_Load(object sender, EventArgs e)
        {
            //p1
            player1_character.Image = CharacterData.Player1._avatar;
            player1_name.Text = CharacterData.Player1._name;
            player1_hp.Minimum = 0;
            player1_hp.Maximum = CharacterData.Player1._maxhp;
            player1_hp.Value = CharacterData.Player1._currenthp;
            player1_mana.Minimum = 0;
            player1_mana.Maximum = CharacterData.Player1._maxmana;
            player1_mana.Value = CharacterData.Player1._currentmana;
            player1_specialattack.Enabled = false;
            player1_defboost.Enabled = true;
            player1_normalattack.Enabled = true;

            //p2
            player2_character.Image = CharacterData.Player2._avatar;
            player2_name.Text = CharacterData.Player2._name;
            player2_hp.Minimum = 0;
            player2_hp.Maximum = CharacterData.Player2._maxhp;
            player2_hp.Value = CharacterData.Player2._currenthp;
            player2_mana.Minimum = 0;
            player2_mana.Maximum = CharacterData.Player2._maxmana;
            player2_mana.Value = CharacterData.Player2._currentmana;
            player2_specialattack.Enabled = false;         //khóa special Attack đầu game 
            player2_defboost.Enabled = false;
            player2_normalattack.Enabled = false;
        }
        private void UpdateUI()
        {
            // ================= PLAYER 1 =================
            player1_hp.Value = CharacterData.Player1._currenthp;
            player1_mana.Value = CharacterData.Player1._currentmana;

            // bật tắt skill theo mana và lượt
            player1_normalattack.Enabled = P1turn;
            player1_specialattack.Enabled = P1turn && CharacterData.Player1._currentmana >= SpecialAttackCost;
            player1_defboost.Enabled = P1turn && CharacterData.Player1._currentmana >= BoostDefCost;

            // ================= PLAYER 2 =================
            player2_hp.Value = CharacterData.Player2._currenthp;
            player2_mana.Value = CharacterData.Player2._currentmana;

            player2_normalattack.Enabled = !P1turn;
            player2_specialattack.Enabled = !P1turn && CharacterData.Player2._currentmana >= SpecialAttackCost;
            player2_defboost.Enabled = !P1turn && CharacterData.Player2._currentmana >= BoostDefCost;
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
            CharacterData.Player1.NormalAttack(CharacterData.Player2);
            UpdateUI();
        }
        private void Player1_SpecialAttack(object sender, EventArgs e)
        {
            P1turn = false;
            CharacterData.Player1.SpecialAttack(CharacterData.Player2);
            UpdateUI();
        }
        private void Player1_DefBoost(object sender, EventArgs e)
        {
            P1turn = false;
            CharacterData.Player1.BoostDef();
            UpdateUI();
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
            P1turn = true;
            CharacterData.Player2.NormalAttack(CharacterData.Player1);
            UpdateUI();
        }
        private void Player2_SpecialAttack(object sender, EventArgs e)
        {
            P1turn = true;
            CharacterData.Player2.SpecialAttack(CharacterData.Player1);
            UpdateUI();
        }
        private void Player2_DefBoost(object sender, EventArgs e)
        {
            P1turn = true;
            CharacterData.Player2.BoostDef();
            UpdateUI();
        }

        private void TextBox(object sender, EventArgs e)
        {

        }

        private void Player1_Mana(object sender, EventArgs e)
        {

        }

        private void Player2_Mana(object sender, EventArgs e)
        {

        }
    }
}
