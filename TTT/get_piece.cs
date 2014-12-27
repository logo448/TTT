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
    public partial class get_piece : Form
    {
        // create a global bool variable to determine if the user is going first
        public static bool _user_first;

        public get_piece()
        {
            InitializeComponent();
        }

        /// <summary>
        /// function that triggers everytime the done button is pressed
        /// main purpose to check if user wants to go first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // check to see if the user pressed the yes radio button
            if (radioButton1.Checked)
            {
                // set the global bool value to true
                _user_first = true;
            }

            // check to see if the user pressed the no button
            if (radioButton2.Checked)
            {
                // set the global bool value to false
                _user_first = false;
            }
        }
    }
}
