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
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = OOP_project.Properties.Resources.battle_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += BackgroundPic;
            // 
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
            // 
            // pictureBox3
            // 
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
            // 
            // Gameplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
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
            Controls.Add(pictureBox1);
            Name = "Gameplay";
            Text = "gameplay";
            Load += Gameplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1_character).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
    }
}
