using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictac
{
    public partial class TicTacToe : Form
    {

        bool turn = true; //true = X turn, false = O turn;
        int turn_count = 0;
        int xWon = 0;
        int oWon = 0;
        int draw = 0;
        static String player1, player2;

        public static void setPlayerNames(String n1,String n2)
        {
            player1 = n1;
            player2 = n2;
        }

        public TicTacToe()
        {
            InitializeComponent();
            lblCountForDraws.Text =draw.ToString();
            lblCountForX.Text = xWon.ToString();
            lblCountsForO.Text = oWon.ToString();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
                
            }
            else
            {
                button.Text = "O";
                
            }

            
            turn = !turn;
            button.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic tac toe by Kenan");
        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal win
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                there_is_a_winner = true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                there_is_a_winner = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                there_is_a_winner = true;

            //vertical win
            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                there_is_a_winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                there_is_a_winner = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                there_is_a_winner = true;

            //diagonal win
            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                there_is_a_winner = true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn7.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

               
                string winner = "";

                if (turn)
                {
                    winner = player2.ToString();
                    oWon++;
                    lblCountsForO.Text = oWon.ToString();
                    
                }
                else
                {
                    winner = player1.ToString();
                    xWon++;
                    lblCountForX.Text = xWon.ToString();
                }
                MessageBox.Show(winner + " is the winner!!!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Its a draw","Bummer");
                    draw++;
                    lblCountForDraws.Text = draw.ToString();
                }
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xWon = 0;
            lblCountForX.Text = xWon.ToString();
            oWon = 0;
            lblCountsForO.Text = oWon.ToString();
            draw = 0;
            lblCountForDraws.Text = draw.ToString();


            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            PlayerRegistration players = new PlayerRegistration();
            players.ShowDialog();
            lblX.Text = player1;
            lblO.Text = player2;
        }
    }
}
