using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace XOGame
{
    public partial class Game : Form
    {
        public string? P1 { get; set; }
        public string? P2 { get; set; }
        public int Score { get; set; }
        private Label winLabel;
        public Game()
        {
            InitializeComponent();

        }
        private void ChangeLabelSizeButton_Click(object sender, EventArgs e)
        {
            // Set new width and height for the label
            int newWidth = 150;
            int newHeight = 50;

            // Change the label size
            label1.Size = new Size(newWidth, newHeight);
        }
        private void Game_Load(object sender, EventArgs e)
        {
            Lbl_player2.Text = P2+" :O";
            Lbl_player1.Text = P1+" :X";
        }
        bool status = true;
        public String XO(bool s)
        {
            if (s == true)
                return "X";
            else
                return "O";
        }
        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (Btn_1.Text == "")
            {
                Btn_1.Text = XO(status);
                if (checkWine(Btn_1.Text))
                {
                    MessageBox.Show(Btn_1.Text + " :is Win");
                    increaseScore(Btn_1.Text);
                }
                status = !status;
            }
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (Btn_2.Text == "")
            {
                Btn_2.Text = XO(status);
                if (checkWine(Btn_2.Text))
                {
                    MessageBox.Show(Btn_2.Text + " :is Win");
                    increaseScore(Btn_2.Text);
                }
                status = !status;
            }

        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (Btn_3.Text == "")
            {
                Btn_3.Text = XO(status);
                if (checkWine(Btn_3.Text))
                {
                    MessageBox.Show(Btn_3.Text + " :is Win");
                    increaseScore(Btn_3.Text);
                }
                status = !status;
            }

        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (Btn_4.Text == "")
            {
                Btn_4.Text = XO(status);
                if (checkWine(Btn_4.Text))
                {
                    MessageBox.Show(Btn_4.Text + " :is Win");
                    increaseScore(Btn_4.Text);
                }
                status = !status;
            }

        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (Btn_5.Text == "")
            {
                Btn_5.Text = XO(status);
                if (checkWine(Btn_5.Text))
                {
                    MessageBox.Show(Btn_5.Text + " :is Win");
                    increaseScore(Btn_5.Text);
                }
                status = !status;
            }

        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (Btn_6.Text == "")
            {
                Btn_6.Text = XO(status);
                if (checkWine(Btn_6.Text))
                {
                    MessageBox.Show(Btn_6.Text + " :is Win");
                    increaseScore(Btn_6.Text);
                }
                status = !status;
            }

        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (Btn_7.Text == "")
            {
                Btn_7.Text = XO(status);
                if (checkWine(Btn_7.Text))
                {
                    MessageBox.Show(Btn_7.Text + " :is Win");
                    increaseScore(Btn_7.Text);
                }
                status = !status;
            }

        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (Btn_8.Text == "")
            {
                Btn_8.Text = XO(status);
                if (checkWine(Btn_8.Text))
                {
                    MessageBox.Show(Btn_8.Text + " :is Win");
                    increaseScore(Btn_8.Text);
                }
                status = !status;
            }

        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (Btn_9.Text == "")
            {
                Btn_9.Text = XO(status);
                if (checkWine(Btn_9.Text))
                {
                    MessageBox.Show(Btn_9.Text + " :is Win");
                    increaseScore(Btn_9.Text);
                }
                status = !status;
            }

        }


        public bool checkWine(String C)
        {
            if (
                (Btn_1.Text == C && Btn_2.Text == C && Btn_3.Text == C) ||
                (Btn_3.Text == C && Btn_6.Text == C && Btn_9.Text == C) ||
                (Btn_2.Text == C && Btn_5.Text == C && Btn_8.Text == C) ||
                (Btn_1.Text == C && Btn_4.Text == C && Btn_7.Text == C) ||
                (Btn_7.Text == C && Btn_8.Text == C && Btn_9.Text == C) ||
                (Btn_6.Text == C && Btn_5.Text == C && Btn_4.Text == C) ||
                (Btn_1.Text == C && Btn_5.Text == C && Btn_9.Text == C) ||
                (Btn_3.Text == C && Btn_5.Text == C && Btn_7.Text == C))
                return true;

            else
                return false;
        }


        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Btn_1.Text = "";
            Btn_2.Text = "";
            Btn_3.Text = "";
            Btn_4.Text = "";
            Btn_5.Text = "";
            Btn_6.Text = "";
            Btn_7.Text = "";
            Btn_8.Text = "";
            Btn_9.Text = "";
        }

        public int getScorep1()
        {
            return int.Parse(Lbl_scorep1.Text) + 1;
        }
        public int getScorep2()
        {
            return int.Parse(Lbl_scorep2.Text) + 1;
        }

        public void increaseScore(String s)
        {
            if (s == "X")
                Lbl_scorep1.Text = getScorep1().ToString();
            else
                Lbl_scorep2.Text = getScorep2().ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
