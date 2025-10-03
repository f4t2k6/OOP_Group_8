namespace Player2_SelectCharacterScreen
{
    partial class Player2_SelectCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            poison_core = new PictureBox();
            fire_core = new PictureBox();
            water_core = new PictureBox();
            electric_core = new PictureBox();
            drapion_button = new Button();
            charizard_button = new Button();
            palkia_button = new Button();
            zekrom_button = new Button();
            player1_title = new TextBox();
            ((System.ComponentModel.ISupportInitialize)poison_core).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fire_core).BeginInit();
            ((System.ComponentModel.ISupportInitialize)water_core).BeginInit();
            ((System.ComponentModel.ISupportInitialize)electric_core).BeginInit();
            SuspendLayout();
            // 
            // poison_core
            // 
            poison_core.Image = OOP_project.Properties.Resources.Type_Poison;
            poison_core.Location = new Point(152, 165);
            poison_core.Name = "poison_core";
            poison_core.Size = new Size(40, 40);
            poison_core.SizeMode = PictureBoxSizeMode.StretchImage;
            poison_core.TabIndex = 0;
            poison_core.TabStop = false;
            poison_core.Click += poison_core_Click;
            // 
            // fire_core
            // 
            fire_core.Image = OOP_project.Properties.Resources.Type_Fire;
            fire_core.Location = new Point(432, 165);
            fire_core.Name = "fire_core";
            fire_core.Size = new Size(40, 40);
            fire_core.SizeMode = PictureBoxSizeMode.StretchImage;
            fire_core.TabIndex = 1;
            fire_core.TabStop = false;
            fire_core.Click += fire_core_Click;
            // 
            // water_core
            // 
            water_core.Image = OOP_project.Properties.Resources.Type_Water;
            water_core.Location = new Point(729, 165);
            water_core.Name = "water_core";
            water_core.Size = new Size(40, 40);
            water_core.SizeMode = PictureBoxSizeMode.StretchImage;
            water_core.TabIndex = 2;
            water_core.TabStop = false;
            water_core.Click += water_core_Click;
            // 
            // electric_core
            // 
            electric_core.Image = OOP_project.Properties.Resources.Type_Electric;
            electric_core.Location = new Point(1043, 165);
            electric_core.Name = "electric_core";
            electric_core.Size = new Size(40, 40);
            electric_core.SizeMode = PictureBoxSizeMode.StretchImage;
            electric_core.TabIndex = 3;
            electric_core.TabStop = false;
            electric_core.Click += electric_core_Click;
            // 
            // drapion_button
            // 
            drapion_button.BackColor = Color.MediumPurple;
            drapion_button.BackgroundImage = OOP_project.Properties.Resources.Icon_Drapion_SLC;
            drapion_button.BackgroundImageLayout = ImageLayout.Zoom;
            drapion_button.Location = new Point(98, 227);
            drapion_button.Name = "drapion_button";
            drapion_button.Size = new Size(150, 150);
            drapion_button.TabIndex = 4;
            drapion_button.UseVisualStyleBackColor = false;
            drapion_button.Click += drapion_button_Click;
            // 
            // charizard_button
            // 
            charizard_button.BackColor = Color.Firebrick;
            charizard_button.BackgroundImage = OOP_project.Properties.Resources.Icon_Charizard_SLC;
            charizard_button.BackgroundImageLayout = ImageLayout.Zoom;
            charizard_button.Location = new Point(375, 227);
            charizard_button.Name = "charizard_button";
            charizard_button.Size = new Size(150, 150);
            charizard_button.TabIndex = 5;
            charizard_button.UseVisualStyleBackColor = false;
            charizard_button.Click += charizard_button_Click;
            // 
            // palkia_button
            // 
            palkia_button.BackColor = Color.DarkTurquoise;
            palkia_button.BackgroundImage = OOP_project.Properties.Resources.Icon_Palkia_SLC;
            palkia_button.BackgroundImageLayout = ImageLayout.Zoom;
            palkia_button.Location = new Point(675, 227);
            palkia_button.Name = "palkia_button";
            palkia_button.RightToLeft = RightToLeft.Yes;
            palkia_button.Size = new Size(150, 150);
            palkia_button.TabIndex = 6;
            palkia_button.UseVisualStyleBackColor = false;
            palkia_button.Click += palkia_button_Click;
            // 
            // zekrom_button
            // 
            zekrom_button.BackColor = Color.Gold;
            zekrom_button.BackgroundImage = OOP_project.Properties.Resources.Icon_Zekrom_SLC;
            zekrom_button.BackgroundImageLayout = ImageLayout.Zoom;
            zekrom_button.Location = new Point(985, 227);
            zekrom_button.Name = "zekrom_button";
            zekrom_button.Size = new Size(150, 150);
            zekrom_button.TabIndex = 7;
            zekrom_button.UseVisualStyleBackColor = false;
            zekrom_button.Click += zekrom_button_Click;
            // 
            // player1_title
            // 
            player1_title.BackColor = Color.Wheat;
            player1_title.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player1_title.Location = new Point(310, 52);
            player1_title.Name = "player1_title";
            player1_title.Size = new Size(630, 66);
            player1_title.TabIndex = 8;
            player1_title.Text = "PLAYER 2 : CHOOSE CHARACTER";
            player1_title.TextAlign = HorizontalAlignment.Center;
            player1_title.TextChanged += Player2_Notify;
            // 
            // Player2_SelectCharacter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1262, 673);
            Controls.Add(player1_title);
            Controls.Add(zekrom_button);
            Controls.Add(palkia_button);
            Controls.Add(charizard_button);
            Controls.Add(drapion_button);
            Controls.Add(electric_core);
            Controls.Add(water_core);
            Controls.Add(fire_core);
            Controls.Add(poison_core);
            Name = "Player2_SelectCharacter";
            Text = "Player1_SelectCharacter";
            Load += Player2_SelectCharacter_Load;
            ((System.ComponentModel.ISupportInitialize)poison_core).EndInit();
            ((System.ComponentModel.ISupportInitialize)fire_core).EndInit();
            ((System.ComponentModel.ISupportInitialize)water_core).EndInit();
            ((System.ComponentModel.ISupportInitialize)electric_core).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox poison_core;
        private PictureBox fire_core;
        private PictureBox water_core;
        private PictureBox electric_core;
        private Button drapion_button;
        private Button charizard_button;
        private Button palkia_button;
        private Button zekrom_button;
        private TextBox player1_title;
    }
}