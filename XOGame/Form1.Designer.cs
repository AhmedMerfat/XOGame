namespace XOGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            TxtB_player1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            TxtB_player2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            Btn_startGame = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 181, 175);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtB_player1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(59, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 166);
            panel1.TabIndex = 0;
            // 
            // TxtB_player1
            // 
            TxtB_player1.Font = new Font("Arial Rounded MT Bold", 18F);
            TxtB_player1.ForeColor = Color.Red;
            TxtB_player1.Location = new Point(53, 116);
            TxtB_player1.Name = "TxtB_player1";
            TxtB_player1.Size = new Size(228, 35);
            TxtB_player1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(53, 67);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F);
            label1.Location = new Point(53, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 0;
            label1.Text = "Player 1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(150, 181, 175);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TxtB_player2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(446, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 166);
            panel2.TabIndex = 1;
            // 
            // TxtB_player2
            // 
            TxtB_player2.Font = new Font("Arial Rounded MT Bold", 18F);
            TxtB_player2.ForeColor = Color.Green;
            TxtB_player2.Location = new Point(50, 116);
            TxtB_player2.Name = "TxtB_player2";
            TxtB_player2.Size = new Size(222, 35);
            TxtB_player2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(50, 67);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F);
            label2.Location = new Point(50, 23);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 0;
            label2.Text = "Player 2";
            // 
            // Btn_startGame
            // 
            Btn_startGame.BackColor = Color.FromArgb(254, 82, 252);
            Btn_startGame.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_startGame.Location = new Point(272, 346);
            Btn_startGame.Name = "Btn_startGame";
            Btn_startGame.Size = new Size(276, 63);
            Btn_startGame.TabIndex = 2;
            Btn_startGame.Text = "Start Game";
            Btn_startGame.UseVisualStyleBackColor = false;
            Btn_startGame.Click += Btn_startGame_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(184, 14);
            label5.Name = "label5";
            label5.Size = new Size(72, 85);
            label5.TabIndex = 3;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 36F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(181, 23);
            label6.Name = "label6";
            label6.Size = new Size(75, 85);
            label6.TabIndex = 4;
            label6.Text = "O";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_startGame);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XOGame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox TxtB_player1;
        private TextBox TxtB_player2;
        private Button Btn_startGame;
        private Label label5;
        private Label label6;
    }
}
