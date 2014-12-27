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
        // a list that represents the board
        private List<int> board_array = new List<int>();

        // variables that will represent of the human and computer are X or O
        private string human;
        private string computer;

        private void get_pieces()
        {

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

        }
    }
}
