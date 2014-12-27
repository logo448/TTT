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
            get_piece1.ShowDialog();

            if (get_piece._user_first)
            {
                this.human = "X";
                this.computer = "O";
                MessageBox.Show(human);
            }
            else
            {
                this.human = "O";
                this.computer = "X";
                MessageBox.Show(human);
            }
        }
    }

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
}
