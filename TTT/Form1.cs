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
            #region testing
            board board1 = new board();
            #endregion
            #region get location
            int pos = 0;

            if (radioButton1.Checked)
            {
                pos = 0;
            }

            if (radioButton2.Checked)
            {
                pos = 2;
            }

            if (radioButton3.Checked)
            {
                pos = 6;
            }

            if (radioButton4.Checked)
            {
                pos = 8;
            }

            if (radioButton5.Checked)
            {
                pos = 3;
            }

            if (radioButton6.Checked)
            {
                pos = 5;
            }

            if (radioButton7.Checked)
            {
                pos = 4;
            }

            if (radioButton8.Checked)
            {
                pos = 1;
            }

            if (radioButton9.Checked)
            {
                pos = 7;
            }
            MessageBox.Show(pos.ToString());
            #endregion
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
        private List<string> board_array = new List<string>();

        // variables that will represent of the human and computer are X or O
        private string human;
        private string computer;

        // a variable that represents if it's x or o's turn
        private string turn = "X";

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

        public void blank_board()
        {
            board_array.AddRange(new string[9] { "", "", "", "", "", "", "", "", "" });
        }
    }
}
