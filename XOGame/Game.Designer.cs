namespace XOGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            label1 = new Label();
            Lbl_player1 = new Label();
            Lbl_player2 = new Label();
            Lbl_scorep1 = new Label();
            Lbl_scorep2 = new Label();
            Btn_reset = new Button();
            Btn_newgame = new Button();
            Btn_savescore = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            Btn_9 = new Button();
            Btn_8 = new Button();
            Btn_7 = new Button();
            Btn_6 = new Button();
            Btn_5 = new Button();
            Btn_4 = new Button();
            Btn_3 = new Button();
            Btn_2 = new Button();
            Btn_1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 0;
            label1.Text = "XO Game";
            // 
            // Lbl_player1
            // 
            Lbl_player1.AutoSize = true;
            Lbl_player1.BackColor = Color.FromArgb(255, 128, 128);
            Lbl_player1.BorderStyle = BorderStyle.FixedSingle;
            Lbl_player1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_player1.ForeColor = Color.Cornsilk;
            Lbl_player1.Location = new Point(546, 86);
            Lbl_player1.Name = "Lbl_player1";
            Lbl_player1.Size = new Size(61, 25);
            Lbl_player1.TabIndex = 1;
            Lbl_player1.Text = "Label";
            Lbl_player1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_player2
            // 
            Lbl_player2.AutoSize = true;
            Lbl_player2.BackColor = Color.FromArgb(255, 128, 128);
            Lbl_player2.BorderStyle = BorderStyle.FixedSingle;
            Lbl_player2.Font = new Font("Britannic Bold", 15.75F);
            Lbl_player2.ForeColor = Color.Cornsilk;
            Lbl_player2.Location = new Point(546, 122);
            Lbl_player2.Name = "Lbl_player2";
            Lbl_player2.Size = new Size(61, 25);
            Lbl_player2.TabIndex = 2;
            Lbl_player2.Text = "Label";
            Lbl_player2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_scorep1
            // 
            Lbl_scorep1.AutoSize = true;
            Lbl_scorep1.BackColor = Color.Transparent;
            Lbl_scorep1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_scorep1.ForeColor = SystemColors.ButtonHighlight;
            Lbl_scorep1.Location = new Point(735, 86);
            Lbl_scorep1.Name = "Lbl_scorep1";
            Lbl_scorep1.Size = new Size(24, 27);
            Lbl_scorep1.TabIndex = 3;
            Lbl_scorep1.Text = "0";
            Lbl_scorep1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_scorep2
            // 
            Lbl_scorep2.AutoSize = true;
            Lbl_scorep2.BackColor = Color.Transparent;
            Lbl_scorep2.Font = new Font("Showcard Gothic", 15.75F);
            Lbl_scorep2.ForeColor = SystemColors.ButtonHighlight;
            Lbl_scorep2.Location = new Point(735, 118);
            Lbl_scorep2.Name = "Lbl_scorep2";
            Lbl_scorep2.Size = new Size(24, 27);
            Lbl_scorep2.TabIndex = 4;
            Lbl_scorep2.Text = "0";
            Lbl_scorep2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_reset
            // 
            Btn_reset.BackColor = Color.FromArgb(255, 128, 128);
            Btn_reset.Font = new Font("Snap ITC", 18F);
            Btn_reset.ForeColor = Color.Honeydew;
            Btn_reset.Location = new Point(572, 265);
            Btn_reset.Name = "Btn_reset";
            Btn_reset.Size = new Size(187, 43);
            Btn_reset.TabIndex = 5;
            Btn_reset.Text = "Reset";
            Btn_reset.UseVisualStyleBackColor = false;
            Btn_reset.Click += Btn_reset_Click;
            // 
            // Btn_newgame
            // 
            Btn_newgame.BackColor = Color.FromArgb(255, 128, 128);
            Btn_newgame.Font = new Font("Snap ITC", 18F);
            Btn_newgame.ForeColor = Color.Honeydew;
            Btn_newgame.Location = new Point(572, 322);
            Btn_newgame.Name = "Btn_newgame";
            Btn_newgame.Size = new Size(187, 43);
            Btn_newgame.TabIndex = 6;
            Btn_newgame.Text = "New Game";
            Btn_newgame.UseVisualStyleBackColor = false;
            // 
            // Btn_savescore
            // 
            Btn_savescore.BackColor = Color.FromArgb(255, 128, 128);
            Btn_savescore.Font = new Font("Snap ITC", 18F);
            Btn_savescore.ForeColor = Color.Honeydew;
            Btn_savescore.Location = new Point(572, 379);
            Btn_savescore.Name = "Btn_savescore";
            Btn_savescore.Size = new Size(187, 43);
            Btn_savescore.TabIndex = 7;
            Btn_savescore.Text = "Save Score";
            Btn_savescore.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Btn_9);
            panel1.Controls.Add(Btn_8);
            panel1.Controls.Add(Btn_7);
            panel1.Controls.Add(Btn_6);
            panel1.Controls.Add(Btn_5);
            panel1.Controls.Add(Btn_4);
            panel1.Controls.Add(Btn_3);
            panel1.Controls.Add(Btn_2);
            panel1.Controls.Add(Btn_1);
            panel1.Location = new Point(21, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 352);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cyan;
            panel5.Location = new Point(18, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 2);
            panel5.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Location = new Point(18, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 2);
            panel4.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Location = new Point(122, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 280);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Location = new Point(263, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 280);
            panel2.TabIndex = 9;
            // 
            // Btn_9
            // 
            Btn_9.FlatAppearance.BorderSize = 0;
            Btn_9.FlatStyle = FlatStyle.Flat;
            Btn_9.Font = new Font("MV Boli", 48F);
            Btn_9.ForeColor = SystemColors.ActiveCaptionText;
            Btn_9.Location = new Point(0, 268);
            Btn_9.Name = "Btn_9";
            Btn_9.Size = new Size(100, 80);
            Btn_9.TabIndex = 8;
            Btn_9.UseVisualStyleBackColor = true;
            Btn_9.Click += Btn_9_Click;
            // 
            // Btn_8
            // 
            Btn_8.FlatAppearance.BorderSize = 0;
            Btn_8.FlatStyle = FlatStyle.Flat;
            Btn_8.Font = new Font("MV Boli", 48F);
            Btn_8.ForeColor = SystemColors.ActiveCaptionText;
            Btn_8.Location = new Point(144, 268);
            Btn_8.Name = "Btn_8";
            Btn_8.Size = new Size(100, 80);
            Btn_8.TabIndex = 7;
            Btn_8.UseVisualStyleBackColor = true;
            Btn_8.Click += Btn_8_Click;
            // 
            // Btn_7
            // 
            Btn_7.FlatAppearance.BorderSize = 0;
            Btn_7.FlatStyle = FlatStyle.Flat;
            Btn_7.Font = new Font("MV Boli", 48F);
            Btn_7.ForeColor = SystemColors.ActiveCaptionText;
            Btn_7.Location = new Point(288, 268);
            Btn_7.Name = "Btn_7";
            Btn_7.Size = new Size(100, 80);
            Btn_7.TabIndex = 6;
            Btn_7.UseVisualStyleBackColor = true;
            Btn_7.Click += Btn_7_Click;
            // 
            // Btn_6
            // 
            Btn_6.FlatAppearance.BorderSize = 0;
            Btn_6.FlatStyle = FlatStyle.Flat;
            Btn_6.Font = new Font("MV Boli", 48F);
            Btn_6.ForeColor = SystemColors.ActiveCaptionText;
            Btn_6.Location = new Point(0, 173);
            Btn_6.Name = "Btn_6";
            Btn_6.Size = new Size(100, 80);
            Btn_6.TabIndex = 5;
            Btn_6.UseVisualStyleBackColor = true;
            Btn_6.Click += Btn_6_Click;
            // 
            // Btn_5
            // 
            Btn_5.FlatAppearance.BorderSize = 0;
            Btn_5.FlatStyle = FlatStyle.Flat;
            Btn_5.Font = new Font("MV Boli", 48F);
            Btn_5.ForeColor = SystemColors.ActiveCaptionText;
            Btn_5.Location = new Point(144, 173);
            Btn_5.Name = "Btn_5";
            Btn_5.Size = new Size(100, 80);
            Btn_5.TabIndex = 4;
            Btn_5.UseVisualStyleBackColor = true;
            Btn_5.Click += Btn_5_Click;
            // 
            // Btn_4
            // 
            Btn_4.FlatAppearance.BorderSize = 0;
            Btn_4.FlatStyle = FlatStyle.Flat;
            Btn_4.Font = new Font("MV Boli", 48F);
            Btn_4.ForeColor = SystemColors.ActiveCaptionText;
            Btn_4.Location = new Point(288, 173);
            Btn_4.Name = "Btn_4";
            Btn_4.Size = new Size(100, 80);
            Btn_4.TabIndex = 3;
            Btn_4.UseVisualStyleBackColor = true;
            Btn_4.Click += Btn_4_Click;
            // 
            // Btn_3
            // 
            Btn_3.FlatAppearance.BorderSize = 0;
            Btn_3.FlatStyle = FlatStyle.Flat;
            Btn_3.Font = new Font("MV Boli", 48F);
            Btn_3.ForeColor = SystemColors.ActiveCaptionText;
            Btn_3.Location = new Point(0, 78);
            Btn_3.Name = "Btn_3";
            Btn_3.Size = new Size(100, 80);
            Btn_3.TabIndex = 2;
            Btn_3.UseVisualStyleBackColor = true;
            Btn_3.Click += Btn_3_Click;
            // 
            // Btn_2
            // 
            Btn_2.BackColor = Color.Transparent;
            Btn_2.FlatAppearance.BorderSize = 0;
            Btn_2.FlatStyle = FlatStyle.Flat;
            Btn_2.Font = new Font("MV Boli", 48F);
            Btn_2.ForeColor = SystemColors.ActiveCaptionText;
            Btn_2.Location = new Point(144, 78);
            Btn_2.Name = "Btn_2";
            Btn_2.Size = new Size(100, 80);
            Btn_2.TabIndex = 1;
            Btn_2.UseVisualStyleBackColor = false;
            Btn_2.Click += Btn_2_Click;
            // 
            // Btn_1
            // 
            Btn_1.FlatAppearance.BorderSize = 0;
            Btn_1.FlatStyle = FlatStyle.Flat;
            Btn_1.Font = new Font("MV Boli", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_1.ForeColor = SystemColors.ActiveCaptionText;
            Btn_1.Location = new Point(288, 78);
            Btn_1.Name = "Btn_1";
            Btn_1.Size = new Size(100, 80);
            Btn_1.TabIndex = 0;
            Btn_1.UseVisualStyleBackColor = true;
            Btn_1.Click += Btn_1_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Btn_savescore);
            Controls.Add(Btn_newgame);
            Controls.Add(Btn_reset);
            Controls.Add(Lbl_scorep2);
            Controls.Add(Lbl_scorep1);
            Controls.Add(Lbl_player2);
            Controls.Add(Lbl_player1);
            Controls.Add(label1);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Game_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Lbl_player1;
        private Label Lbl_player2;
        private Label Lbl_scorep1;
        private Label Lbl_scorep2;
        private Button Btn_reset;
        private Button Btn_newgame;
        private Button Btn_savescore;
        private Panel panel1;
        private Button Btn_9;
        private Button Btn_8;
        private Button Btn_7;
        private Button Btn_6;
        private Button Btn_5;
        private Button Btn_4;
        private Button Btn_3;
        private Button Btn_2;
        private Button Btn_1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
    }
}