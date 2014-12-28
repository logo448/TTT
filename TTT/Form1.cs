using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        // new global board object for testing
        board board1 = new board();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function that triggers when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {           
            #region get location and do stuff
            // integer variable that represents which radiobutton the user selected
            int pos = 0;

            // section that checks all nine radiobuttons to see
            // which radiobutton is selected and then assigns pos to the appropriate value
            if (radioButton1.Checked)
            {
                pos = 0;

                // make radio button dissapear
                radioButton1.Visible = false;
                // set the text of the label to the current players symbol
                label1.Text = board1.turn;
            }

            if (radioButton2.Checked)
            {
                pos = 2;

                // make radio button dissapear
                radioButton2.Visible = false;
                // set the text of the label to the current players symbol
                label3.Text = board1.turn;
            }

            if (radioButton3.Checked)
            {
                pos = 6;

                // make radio button dissapear
                radioButton3.Visible = false;
                // set the text of the label to the current players symbol
                label7.Text = board1.turn;
            }

            if (radioButton4.Checked)
            {
                pos = 8;

                // make radio button dissapear
                radioButton4.Visible = false;
                // set the text of the label to the current players symbol
                label9.Text = board1.turn;
            }

            if (radioButton5.Checked)
            {
                pos = 3;

                // make radio button dissapear
                radioButton5.Visible = false;
                // set the text of the label to the current players symbol
                label4.Text = board1.turn;
            }

            if (radioButton6.Checked)
            {
                pos = 5;

                // make radio button dissapear
                radioButton6.Visible = false;
                // set the text of the label to the current players symbol
                label6.Text = board1.turn;
            }

            if (radioButton7.Checked)
            {
                pos = 4;

                // make radio button dissapear
                radioButton7.Visible = false;
                // set the text of the label to the current players symbol
                label5.Text = board1.turn;
            }

            if (radioButton8.Checked)
            {
                pos = 1;

                // make radio button dissapear
                radioButton8.Visible = false;
                // set the text of the label to the current players symbol
                label2.Text = board1.turn;
            }

            if (radioButton9.Checked)
            {
                pos = 7;

                // make radio button dissapear
                radioButton9.Visible = false;
                // set the text of the label to the current players symbol
                label8.Text = board1.turn;
            }
            #endregion
            board1.mark_move(pos);
            board1.check_for_win();
            board1.next_turn();
        }
    }

    /// <summary>
    /// a class that is the tic tac toe board
    /// </summary>
    public class board
    {
        // a list that represents the board
        private List<string> board_array = new List<string>();

        // a variable that represents if it's x or o's turn
        public string turn;

        // a variable that holds the legal moves
        private List<int> legal_moves;

        // a variable that holds a list of all x's moves
        private List<int> x_moves;

        // a variable that holds a list of all o's moves
        private List<int> o_moves;

        /// <summary>
        /// runs on creation of object
        /// </summary>
        public board()
        {
            turn = "X";
            blank_board();
        }       

        /// <summary>
        /// function that switches the turn from x to o or o to x
        /// </summary>
        public void next_turn()
        {
            // if it was X's turn
            if (turn == "X")
            {
                // switch to O's turn
                turn = "O";
            }

            // if it was O's turn
            else
            {
                // switch to X's turn
                turn = "X";
            }
        }

        /// <summary>
        /// function that clears the board
        /// </summary>
        public void blank_board()
        {
            board_array.AddRange(new string[9] { "", "", "", "", "", "", "", "", "" });
        }

        /// <summary>
        /// function to mark the move passed to the function on
        /// the board
        /// </summary>
        /// <param name="move"></param>
        public void mark_move(int move)
        {
            // sets the value of the nth element of the board to
            // either x or o depending on who's turn it is. N is
            // equal to the move passed to the method.
            board_array[move] = turn;
        }

        /// <summary>
        /// function that gets all legal moves and stores them in
        /// the legal moves list
        /// </summary>
        public void get_legal_moves()
        {
            // reset the legal_moves
            legal_moves = new List<int>();

            // counter variable
            int n = 0;

            // loops through each position on the board
            foreach (string pos in board_array)
            {
                // if the pos is empty
                if (pos == "")
                {
                    // the space is legal
                    legal_moves.Add(n);
                }
                // increment counter variable
                n++;
            }
        }

        /// <summary>
        /// function to get the moves x and o have made and store
        /// them in a list
        /// </summary>
        public void get_xO_moves()
        {
            // reset's x and o moves
            o_moves = new List<int>();
            x_moves = new List<int>();

            // counter variable used to get current position in loop
            int n = 0;

            // loop through every board position
            foreach (string pos in board_array)
            {
                // if position is marked by x
                if (pos == "X")
                {
                    // add position to x move list
                    x_moves.Add(n);
                }

                // if position is marked by o
                if (pos == "O")
                {
                    // add the position to the o move list
                    o_moves.Add(n);
                }
                // icrement counter variable
                n++;
            }
        }

        /// <summary>
        /// function that checks to see if their is a winning patter
        /// on the board
        /// </summary>
        /// <returns>
        /// returns either null, x, or o
        /// </returns>
        public string check_for_win()
        {
            // update x and o's moves
            get_xO_moves();

            // 2d array to hold the winning combos
            int[,] winning_combos = new int[8, 3] {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
            };

            // loop through the 1st layer of the combos
            for (int i = 0; i < 8; i++)
            {
                // if x moves contains all three position in current
                // wining combo row
                if (x_moves.Contains(winning_combos[i,0]) 
                    && x_moves.Contains(winning_combos[i,1])
                    && x_moves.Contains(winning_combos[i, 2]))
                {
                    // return "X" as winner
                    return "X";
                }

                // if o moves contains all three position in current
                // wining combo row
                if (o_moves.Contains(winning_combos[i, 0])
                    && o_moves.Contains(winning_combos[i, 1])
                    && o_moves.Contains(winning_combos[i, 2]))
                {
                    // return "O" as winner
                    return "O";
                }
            }
            // no winner
            return null;
        }
    }
}
