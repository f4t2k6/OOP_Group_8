namespace ManChoi
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
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
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
            // 
            // Pic_Enemy
            // 
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
            // 
            // Gameplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
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
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Gameplay";
            Text = "gameplay";
            Load += Gameplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Enemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
    }
}
