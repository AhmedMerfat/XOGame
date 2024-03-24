namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_startGame_Click(object sender, EventArgs e)
        {

            String player1 = TxtB_player1.Text;
            String player2 = TxtB_player2.Text;
            if (string.IsNullOrEmpty(player1) || string.IsNullOrEmpty(player2))
            {
                MessageBox.Show("You Should Enter All Player", "Error!!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();

                Game game = new Game();
                game.P1 = player1; 
                game.P2 = player2; 
                game.ShowDialog();

                // Close the current form
                this.Close();


            }

        }
    }
}
