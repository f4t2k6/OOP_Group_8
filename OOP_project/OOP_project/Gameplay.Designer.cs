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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Fusion_Bolt = new Button();
            Thunder = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            HPBot = new ProgressBar();
            HPhuman = new ProgressBar();
            human_name = new Label();
            bot_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 558);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = OOP_project.Properties.Resources.zekrom;
            pictureBox2.Location = new Point(218, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 273);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = OOP_project.Properties.Resources.dragon;
            pictureBox3.Location = new Point(707, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(305, 311);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Fusion_Bolt
            // 
            Fusion_Bolt.Location = new Point(151, 87);
            Fusion_Bolt.Name = "Fusion_Bolt";
            Fusion_Bolt.Size = new Size(73, 48);
            Fusion_Bolt.TabIndex = 3;
            Fusion_Bolt.Text = "Fusion Bolt";
            Fusion_Bolt.UseVisualStyleBackColor = true;
            Fusion_Bolt.Click += Fusion_Bolt_Click;
            // 
            // Thunder
            // 
            Thunder.Location = new Point(151, 151);
            Thunder.Name = "Thunder";
            Thunder.Size = new Size(73, 48);
            Thunder.TabIndex = 4;
            Thunder.Text = "Thunder";
            Thunder.UseVisualStyleBackColor = true;
            Thunder.Click += Thunder_Click;
            // 
            // button3
            // 
            button3.Location = new Point(267, 112);
            button3.Name = "button3";
            button3.Size = new Size(45, 48);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1046, 87);
            button4.Name = "button4";
            button4.Size = new Size(45, 48);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1046, 151);
            button5.Name = "button5";
            button5.Size = new Size(45, 48);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(952, 122);
            button6.Name = "button6";
            button6.Size = new Size(45, 48);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // HPBot
            // 
            HPBot.Location = new Point(793, 51);
            HPBot.Name = "HPBot";
            HPBot.Size = new Size(142, 29);
            HPBot.TabIndex = 9;
            HPBot.Value = 100;
            HPBot.Click += progressBar1_Click;
            // 
            // HPhuman
            // 
            HPhuman.Location = new Point(267, 51);
            HPhuman.Name = "HPhuman";
            HPhuman.Size = new Size(142, 29);
            HPhuman.TabIndex = 10;
            HPhuman.Value = 100;
            HPhuman.Click += HPhuman_Click;
            // 
            // human_name
            // 
            human_name.AutoSize = true;
            human_name.Location = new Point(267, 28);
            human_name.Name = "human_name";
            human_name.Size = new Size(60, 20);
            human_name.TabIndex = 11;
            human_name.Text = "Zekrom";
            human_name.TextAlign = ContentAlignment.MiddleCenter;
            human_name.Click += label1_Click;
            // 
            // bot_name
            // 
            bot_name.AutoSize = true;
            bot_name.Location = new Point(863, 28);
            bot_name.Name = "bot_name";
            bot_name.Size = new Size(72, 20);
            bot_name.TabIndex = 12;
            bot_name.Text = "Charizard";
            bot_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gameplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 558);
            Controls.Add(bot_name);
            Controls.Add(human_name);
            Controls.Add(HPhuman);
            Controls.Add(HPBot);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Thunder);
            Controls.Add(Fusion_Bolt);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Gameplay";
            Text = "gameplay";
            Load += Gameplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Fusion_Bolt;
        private Button Thunder;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ProgressBar HPBot;
        private ProgressBar HPhuman;
        private Label human_name;
        private Label bot_name;
    }
}
