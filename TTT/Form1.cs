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
            board board1 = new board();
            board1.get_pieces();
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
        private List<int> board_array = new List<int>();

        // variables that will represent of the human and computer are X or O
        private string human;
        private string computer;

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
    }
}
