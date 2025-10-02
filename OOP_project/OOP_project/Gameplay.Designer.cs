namespace GameplayScreen
{
    partial class Gameplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            pictureBox1 = new PictureBox();
<<<<<<< HEAD
            Pic_Player = new PictureBox();
            Pic_Enemy = new PictureBox();
            Skill1_Player = new Button();
            Skill2_Player = new Button();
            Item_Player = new Button();
            Skill1_Enemy = new Button();
            Skill2_Enemy = new Button();
            Item_Enemy = new Button();
            Enemy_HP = new ProgressBar();
            Player_HP = new ProgressBar();
            Player_name = new Label();
            Enemy_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Enemy).BeginInit();
=======
            player1_character = new PictureBox();
            pictureBox3 = new PictureBox();
            player1_specialattack = new Button();
            player1_defboost = new Button();
            player1_normalattack = new Button();
            player2_specialattack = new Button();
            player2_defboost = new Button();
            player2_normalattack = new Button();
            player2_hp = new ProgressBar();
            player1_hp = new ProgressBar();
            player1_name = new Label();
            player2_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1_character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
>>>>>>> main
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = OOP_project.Properties.Resources.battle_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
<<<<<<< HEAD
            pictureBox1.Size = new Size(1262, 673);
=======
            pictureBox1.Size = new Size(1280, 720);
>>>>>>> main
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += BackgroundPic;
            // 
<<<<<<< HEAD
            // Pic_Player
            // 
            Pic_Player.BackColor = Color.Transparent;
            Pic_Player.BackgroundImage = (Image)resources.GetObject("Pic_Player.BackgroundImage");
            Pic_Player.BackgroundImageLayout = ImageLayout.Stretch;
            Pic_Player.Location = new Point(222, 288);
            Pic_Player.Name = "Pic_Player";
            Pic_Player.Size = new Size(294, 304);
            Pic_Player.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Player.TabIndex = 1;
            Pic_Player.TabStop = false;
            Pic_Player.Click += pictureBox2_Click;
=======
            // player1_character
            // 
            player1_character.BackColor = Color.Transparent;
            player1_character.BackgroundImageLayout = ImageLayout.Stretch;
            player1_character.Image = (Image)resources.GetObject("player1_character.Image");
            player1_character.Location = new Point(208, 236);
            player1_character.Name = "player1_character";
            player1_character.Size = new Size(250, 250);
            player1_character.SizeMode = PictureBoxSizeMode.Zoom;
            player1_character.TabIndex = 1;
            player1_character.TabStop = false;
            player1_character.Click += Player1_Character;
>>>>>>> main
            // 
            // Pic_Enemy
            // 
<<<<<<< HEAD
            Pic_Enemy.BackgroundImage = (Image)resources.GetObject("Pic_Enemy.BackgroundImage");
            Pic_Enemy.BackgroundImageLayout = ImageLayout.Stretch;
            Pic_Enemy.Location = new Point(765, 288);
            Pic_Enemy.Name = "Pic_Enemy";
            Pic_Enemy.Size = new Size(302, 285);
            Pic_Enemy.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Enemy.TabIndex = 2;
            Pic_Enemy.TabStop = false;
            Pic_Enemy.Click += pictureBox3_Click;
            // 
            // Skill1_Player
            // 
            Skill1_Player.Location = new Point(192, 598);
            Skill1_Player.Name = "Skill1_Player";
            Skill1_Player.Size = new Size(69, 63);
            Skill1_Player.TabIndex = 3;
            Skill1_Player.Text = "1";
            Skill1_Player.UseVisualStyleBackColor = true;
            Skill1_Player.Click += Fusion_Bolt_Click;
            // 
            // Skill2_Player
            // 
            Skill2_Player.Location = new Point(303, 598);
            Skill2_Player.Name = "Skill2_Player";
            Skill2_Player.Size = new Size(69, 63);
            Skill2_Player.TabIndex = 4;
            Skill2_Player.Text = "2";
            Skill2_Player.UseVisualStyleBackColor = true;
            Skill2_Player.Click += Thunder_Click;
            // 
            // Item_Player
            // 
            Item_Player.Location = new Point(455, 613);
            Item_Player.Name = "Item_Player";
            Item_Player.Size = new Size(45, 48);
            Item_Player.TabIndex = 5;
            Item_Player.UseVisualStyleBackColor = true;
            Item_Player.Click += button3_Click;
            // 
            // Skill1_Enemy
            // 
            Skill1_Enemy.Location = new Point(916, 579);
            Skill1_Enemy.Name = "Skill1_Enemy";
            Skill1_Enemy.Size = new Size(69, 63);
            Skill1_Enemy.TabIndex = 6;
            Skill1_Enemy.Text = "2";
            Skill1_Enemy.UseVisualStyleBackColor = true;
            // 
            // Skill2_Enemy
            // 
            Skill2_Enemy.Location = new Point(1027, 579);
            Skill2_Enemy.Name = "Skill2_Enemy";
            Skill2_Enemy.Size = new Size(69, 63);
            Skill2_Enemy.TabIndex = 7;
            Skill2_Enemy.Text = "1";
            Skill2_Enemy.UseVisualStyleBackColor = true;
            // 
            // Item_Enemy
            // 
            Item_Enemy.Location = new Point(813, 594);
            Item_Enemy.Name = "Item_Enemy";
            Item_Enemy.Size = new Size(45, 48);
            Item_Enemy.TabIndex = 8;
            Item_Enemy.UseVisualStyleBackColor = true;
            // 
            // Enemy_HP
            // 
            Enemy_HP.Location = new Point(863, 51);
            Enemy_HP.Name = "Enemy_HP";
            Enemy_HP.Size = new Size(204, 29);
            Enemy_HP.TabIndex = 9;
            Enemy_HP.Value = 100;
            Enemy_HP.Click += progressBar1_Click;
            // 
            // Player_HP
            // 
            Player_HP.Location = new Point(222, 51);
            Player_HP.Name = "Player_HP";
            Player_HP.Size = new Size(204, 29);
            Player_HP.TabIndex = 10;
            Player_HP.Value = 100;
            Player_HP.Click += HPhuman_Click;
            // 
            // Player_name
            // 
            Player_name.AutoSize = true;
            Player_name.Location = new Point(268, 28);
            Player_name.Name = "Player_name";
            Player_name.RightToLeft = RightToLeft.No;
            Player_name.Size = new Size(50, 20);
            Player_name.TabIndex = 11;
            Player_name.Text = "player";
            Player_name.TextAlign = ContentAlignment.MiddleRight;
            Player_name.Click += label1_Click;
            // 
            // Enemy_name
            // 
            Enemy_name.AutoSize = true;
            Enemy_name.Location = new Point(973, 28);
            Enemy_name.Name = "Enemy_name";
            Enemy_name.Size = new Size(53, 20);
            Enemy_name.TabIndex = 12;
            Enemy_name.Text = "enemy";
            Enemy_name.TextAlign = ContentAlignment.MiddleCenter;
            Enemy_name.Click += bot_name_Click;
=======
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(813, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Player2_Character;
            // 
            // player1_specialattack
            // 
            player1_specialattack.Location = new Point(279, 127);
            player1_specialattack.Name = "player1_specialattack";
            player1_specialattack.Size = new Size(80, 50);
            player1_specialattack.TabIndex = 3;
            player1_specialattack.Text = "Special Attack";
            player1_specialattack.UseVisualStyleBackColor = true;
            player1_specialattack.Click += Player1_SpecialAttack;
            // 
            // player1_defboost
            // 
            player1_defboost.Location = new Point(182, 127);
            player1_defboost.Name = "player1_defboost";
            player1_defboost.Size = new Size(80, 50);
            player1_defboost.TabIndex = 4;
            player1_defboost.Text = "Defense Boost";
            player1_defboost.UseVisualStyleBackColor = true;
            player1_defboost.Click += Player1_DefBoost;
            // 
            // player1_normalattack
            // 
            player1_normalattack.Location = new Point(378, 127);
            player1_normalattack.Name = "player1_normalattack";
            player1_normalattack.Size = new Size(80, 50);
            player1_normalattack.TabIndex = 5;
            player1_normalattack.Text = "Normal Attack";
            player1_normalattack.UseVisualStyleBackColor = true;
            player1_normalattack.Click += Player1_NormalAttack;
            // 
            // player2_specialattack
            // 
            player2_specialattack.Location = new Point(911, 127);
            player2_specialattack.Name = "player2_specialattack";
            player2_specialattack.Size = new Size(80, 50);
            player2_specialattack.TabIndex = 6;
            player2_specialattack.Text = "Special Attack";
            player2_specialattack.UseVisualStyleBackColor = true;
            player2_specialattack.Click += Player2_SpecialAttack;
            // 
            // player2_defboost
            // 
            player2_defboost.Location = new Point(1009, 127);
            player2_defboost.Name = "player2_defboost";
            player2_defboost.Size = new Size(80, 50);
            player2_defboost.TabIndex = 7;
            player2_defboost.Text = "Defense Boost";
            player2_defboost.UseVisualStyleBackColor = true;
            player2_defboost.Click += Player2_DefBoost;
            // 
            // player2_normalattack
            // 
            player2_normalattack.Location = new Point(813, 127);
            player2_normalattack.Name = "player2_normalattack";
            player2_normalattack.Size = new Size(80, 50);
            player2_normalattack.TabIndex = 8;
            player2_normalattack.Text = "Normal Attack";
            player2_normalattack.UseVisualStyleBackColor = true;
            player2_normalattack.Click += Player2_NormalAttack;
            // 
            // player2_hp
            // 
            player2_hp.Location = new Point(813, 71);
            player2_hp.Name = "player2_hp";
            player2_hp.Size = new Size(250, 29);
            player2_hp.TabIndex = 9;
            player2_hp.Value = 100;
            player2_hp.Click += Player2_HP;
            // 
            // player1_hp
            // 
            player1_hp.Location = new Point(208, 71);
            player1_hp.Name = "player1_hp";
            player1_hp.Size = new Size(250, 29);
            player1_hp.TabIndex = 10;
            player1_hp.Value = 100;
            player1_hp.Click += Player1_HP;
            // 
            // player1_name
            // 
            player1_name.AutoSize = true;
            player1_name.Location = new Point(299, 48);
            player1_name.Name = "player1_name";
            player1_name.Size = new Size(60, 20);
            player1_name.TabIndex = 11;
            player1_name.Text = "Zekrom";
            player1_name.TextAlign = ContentAlignment.MiddleCenter;
            player1_name.Click += Player1_Name;
            // 
            // player2_name
            // 
            player2_name.AutoSize = true;
            player2_name.Location = new Point(911, 48);
            player2_name.Name = "player2_name";
            player2_name.Size = new Size(72, 20);
            player2_name.TabIndex = 12;
            player2_name.Text = "Charizard";
            player2_name.TextAlign = ContentAlignment.MiddleCenter;
            player2_name.Click += Player2_Name;
>>>>>>> main
            // 
            // Gameplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
<<<<<<< HEAD
            ClientSize = new Size(1262, 673);
            Controls.Add(Enemy_name);
            Controls.Add(Player_name);
            Controls.Add(Player_HP);
            Controls.Add(Enemy_HP);
            Controls.Add(Item_Enemy);
            Controls.Add(Skill2_Enemy);
            Controls.Add(Skill1_Enemy);
            Controls.Add(Item_Player);
            Controls.Add(Skill2_Player);
            Controls.Add(Skill1_Player);
            Controls.Add(Pic_Enemy);
            Controls.Add(Pic_Player);
=======
            ClientSize = new Size(1280, 558);
            Controls.Add(player2_name);
            Controls.Add(player1_name);
            Controls.Add(player1_hp);
            Controls.Add(player2_hp);
            Controls.Add(player2_normalattack);
            Controls.Add(player2_defboost);
            Controls.Add(player2_specialattack);
            Controls.Add(player1_normalattack);
            Controls.Add(player1_defboost);
            Controls.Add(player1_specialattack);
            Controls.Add(pictureBox3);
            Controls.Add(player1_character);
>>>>>>> main
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gameplay";
            Text = "gameplay";
            Load += Gameplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)Pic_Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Enemy).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)player1_character).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
>>>>>>> main
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
<<<<<<< HEAD
        private PictureBox Pic_Player;
        private PictureBox Pic_Enemy;
        private Button Skill1_Player;
        private Button Skill2_Player;
        private Button Item_Player;
        private Button Skill1_Enemy;
        private Button Skill2_Enemy;
        private Button Item_Enemy;
        private ProgressBar Enemy_HP;
        private ProgressBar Player_HP;
        private Label Player_name;
        private Label Enemy_name;
=======
        private PictureBox player1_character;
        private PictureBox pictureBox3;
        private Button player1_specialattack;
        private Button player1_defboost;
        private Button player1_normalattack;
        private Button player2_specialattack;
        private Button player2_defboost;
        private Button player2_normalattack;
        private ProgressBar player2_hp;
        private ProgressBar player1_hp;
        private Label player1_name;
        private Label player2_name;
>>>>>>> main
    }
}
