namespace Simon_Part_1
{
    partial class Simon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.currentLevelLabel = new System.Windows.Forms.Label();
            this.blueButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.redButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.greenButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIMON GAME";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerNameLabel.Location = new System.Drawing.Point(25, 135);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(184, 38);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "Welcome: ";
            // 
            // currentLevelLabel
            // 
            this.currentLevelLabel.AutoSize = true;
            this.currentLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLevelLabel.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentLevelLabel.ForeColor = System.Drawing.Color.White;
            this.currentLevelLabel.Location = new System.Drawing.Point(25, 190);
            this.currentLevelLabel.Name = "currentLevelLabel";
            this.currentLevelLabel.Size = new System.Drawing.Size(250, 38);
            this.currentLevelLabel.TabIndex = 10;
            this.currentLevelLabel.Text = "Current Level: ";
            // 
            // blueButtonPictureBox
            // 
            this.blueButtonPictureBox.Image = global::Simon_Part_1.Properties.Resources.BlueButtonDark;
            this.blueButtonPictureBox.Location = new System.Drawing.Point(358, 481);
            this.blueButtonPictureBox.Name = "blueButtonPictureBox";
            this.blueButtonPictureBox.Size = new System.Drawing.Size(211, 207);
            this.blueButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueButtonPictureBox.TabIndex = 11;
            this.blueButtonPictureBox.TabStop = false;
            this.blueButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseDown);
            this.blueButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseUp);
            // 
            // yellowButtonPictureBox
            // 
            this.yellowButtonPictureBox.Image = global::Simon_Part_1.Properties.Resources.YelloButtonDark;
            this.yellowButtonPictureBox.Location = new System.Drawing.Point(158, 481);
            this.yellowButtonPictureBox.Name = "yellowButtonPictureBox";
            this.yellowButtonPictureBox.Size = new System.Drawing.Size(211, 207);
            this.yellowButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowButtonPictureBox.TabIndex = 12;
            this.yellowButtonPictureBox.TabStop = false;
            this.yellowButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseDown);
            this.yellowButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseUp);
            // 
            // redButtonPictureBox
            // 
            this.redButtonPictureBox.Image = global::Simon_Part_1.Properties.Resources.RedButtonDark;
            this.redButtonPictureBox.Location = new System.Drawing.Point(358, 281);
            this.redButtonPictureBox.Name = "redButtonPictureBox";
            this.redButtonPictureBox.Size = new System.Drawing.Size(211, 207);
            this.redButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redButtonPictureBox.TabIndex = 13;
            this.redButtonPictureBox.TabStop = false;
            this.redButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseDown);
            this.redButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseUp);
            // 
            // greenButtonPictureBox
            // 
            this.greenButtonPictureBox.Image = global::Simon_Part_1.Properties.Resources.GreenButtonDark;
            this.greenButtonPictureBox.Location = new System.Drawing.Point(158, 281);
            this.greenButtonPictureBox.Name = "greenButtonPictureBox";
            this.greenButtonPictureBox.Size = new System.Drawing.Size(211, 207);
            this.greenButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenButtonPictureBox.TabIndex = 14;
            this.greenButtonPictureBox.TabStop = false;
            this.greenButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseDown);
            this.greenButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Simon_Part_1.Properties.Resources.SimonSym_black_back;
            this.pictureBox1.Location = new System.Drawing.Point(389, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Lime;
            this.startGameButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startGameButton.Location = new System.Drawing.Point(241, 697);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(262, 41);
            this.startGameButton.TabIndex = 16;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1100;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 1100;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1100;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(538, 697);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 41);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Save and Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Simon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(756, 750);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.greenButtonPictureBox);
            this.Controls.Add(this.yellowButtonPictureBox);
            this.Controls.Add(this.blueButtonPictureBox);
            this.Controls.Add(this.currentLevelLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redButtonPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Simon";
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.Simon_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPictureBox_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label playerNameLabel;
        private Label currentLevelLabel;
        private PictureBox blueButtonPictureBox;
        private PictureBox yellowButtonPictureBox;
        private PictureBox redButtonPictureBox;
        private PictureBox greenButtonPictureBox;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        public Button startGameButton;
        private Button exitButton;
    }
}