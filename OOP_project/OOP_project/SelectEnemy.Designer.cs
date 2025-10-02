namespace OOP_project
{
    partial class SelectEnemy
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pokemon2 = new Label();
            pokemon3 = new Label();
            pokemon4 = new Label();
            pokemon1 = new Label();
            Poke4 = new Button();
            Poke3 = new Button();
            Poke2 = new Button();
            Poke1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Logo_ElectricType;
            pictureBox4.Location = new Point(985, 96);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_WaterType;
            pictureBox3.Location = new Point(767, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_FireType;
            pictureBox2.Location = new Point(458, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_PoisonType;
            pictureBox1.Location = new Point(231, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pokemon2
            // 
            pokemon2.AutoSize = true;
            pokemon2.BackColor = Color.OrangeRed;
            pokemon2.Location = new Point(441, 305);
            pokemon2.Name = "pokemon2";
            pokemon2.Size = new Size(72, 20);
            pokemon2.TabIndex = 19;
            pokemon2.Text = "Charizard";
            // 
            // pokemon3
            // 
            pokemon3.AutoSize = true;
            pokemon3.BackColor = Color.Aqua;
            pokemon3.Location = new Point(762, 305);
            pokemon3.Name = "pokemon3";
            pokemon3.Size = new Size(47, 20);
            pokemon3.TabIndex = 18;
            pokemon3.Text = "Palkia";
            // 
            // pokemon4
            // 
            pokemon4.AutoSize = true;
            pokemon4.BackColor = Color.Gold;
            pokemon4.Location = new Point(976, 305);
            pokemon4.Name = "pokemon4";
            pokemon4.Size = new Size(60, 20);
            pokemon4.TabIndex = 17;
            pokemon4.Text = "Zekrom";
            // 
            // pokemon1
            // 
            pokemon1.AutoSize = true;
            pokemon1.BackColor = Color.MediumPurple;
            pokemon1.Location = new Point(221, 305);
            pokemon1.Name = "pokemon1";
            pokemon1.Size = new Size(63, 20);
            pokemon1.TabIndex = 16;
            pokemon1.Text = "Drapion";
            // 
            // Poke4
            // 
            Poke4.BackColor = Color.Gold;
            Poke4.Image = Properties.Resources.Icon_Zekrom_SelectCharacter;
            Poke4.Location = new Point(935, 144);
            Poke4.Name = "Poke4";
            Poke4.Size = new Size(131, 134);
            Poke4.TabIndex = 15;
            Poke4.UseVisualStyleBackColor = false;
            // 
            // Poke3
            // 
            Poke3.BackColor = Color.Aqua;
            Poke3.Image = Properties.Resources.Icon_Palkia_SelectCharacter;
            Poke3.Location = new Point(717, 144);
            Poke3.Name = "Poke3";
            Poke3.Size = new Size(131, 134);
            Poke3.TabIndex = 14;
            Poke3.UseVisualStyleBackColor = false;
            Poke3.Click += Poke3_Click;
            // 
            // Poke2
            // 
            Poke2.BackColor = Color.OrangeRed;
            Poke2.ForeColor = SystemColors.ControlText;
            Poke2.Image = Properties.Resources.Icon_Charizard_SelectCharacter;
            Poke2.Location = new Point(409, 144);
            Poke2.Name = "Poke2";
            Poke2.Size = new Size(131, 134);
            Poke2.TabIndex = 13;
            Poke2.UseVisualStyleBackColor = false;
            Poke2.Click += Poke2_Click;
            // 
            // Poke1
            // 
            Poke1.BackColor = Color.MediumPurple;
            Poke1.BackgroundImageLayout = ImageLayout.Zoom;
            Poke1.Image = Properties.Resources.Icon_Drapion_SelectCharacter;
            Poke1.Location = new Point(185, 144);
            Poke1.Name = "Poke1";
            Poke1.Size = new Size(131, 134);
            Poke1.TabIndex = 12;
            Poke1.UseVisualStyleBackColor = false;
            // 
            // SelectEnemy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_SelectCharacter;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pokemon2);
            Controls.Add(pokemon3);
            Controls.Add(pokemon4);
            Controls.Add(pokemon1);
            Controls.Add(Poke4);
            Controls.Add(Poke3);
            Controls.Add(Poke2);
            Controls.Add(Poke1);
            DoubleBuffered = true;
            Name = "SelectEnemy";
            Text = "SelectEnemy";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label pokemon2;
        private Label pokemon3;
        private Label pokemon4;
        private Label pokemon1;
        private Button Poke4;
        private Button Poke3;
        private Button Poke2;
        private Button Poke1;
    }
}