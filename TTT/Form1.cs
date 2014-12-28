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
        board board1 = new board();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function that triggers when done button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            board1.get_legal_moves();
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
            board1.next_turn();
        }
    }

    /// <summary>
    /// a class that is the tic tac toe board
    /// </summary>
    public class board
    {
        // create a new get_piece form object
        get_piece get_piece1 = new get_piece();

        // a list that represents the board
        public List<string> board_array = new List<string>();

        // variables that will represent of the human and computer are X or O
        public string human;
        public string computer;

        // a variable that represents if it's x or o's turn
        public string turn;

        // a variable that holds the legal moves
        public List<int> legal_moves;

        /// <summary>
        /// runs on creation of object
        /// </summary>
        public board()
        {
            this.turn = "X";
            this.blank_board();
        }

        /// <summary>
        /// function that sets human and computer to either x or o
        /// depending on if the user is going first
        /// </summary>
        public void get_pieces()
        {
            // shows the form that asks the user if they want to go first
            // waits for form to be closed as well
            get_piece1.ShowDialog();
            
            // checks to see if the user is first
            if (get_piece._user_first)
            {
                // set prices accordingly
                this.human = "X";
                this.computer = "O";
            }

            // if human differed
            else
            {
                // set prices accordingly
                this.human = "O";
                this.computer = "X";
            }
        }

        /// <summary>
        /// function that switches the turn from x to o or o to x
        /// </summary>
        public void next_turn()
        {
            // if it was X's turn
            if (this.turn == "X")
            {
                // switch to O's turn
                this.turn = "O";
            }

            // if it was O's turn
            else
            {
                // switch to X's turn
                this.turn = "X";
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
            this.board_array[move] = turn;
        }

        /// <summary>
        /// function that gets all legal moves and stores them in
        /// the legal moves list
        /// </summary>
        public void get_legal_moves()
        {
            // reset the legal_moves
            this.legal_moves = new List<int>();

            // counter variable
            int n = 0;

            // loops through each position on the board
            foreach (string pos in board_array)
            {
                // if the pos is empty
                if (pos == "")
                {
                    // the space is legal
                    this.legal_moves.Add(n);
                }
                // increment counter variable
                n++;
            }
        }
    }
}
