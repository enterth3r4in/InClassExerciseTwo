using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * In Class Exercise Two
 * Author: Cody Miller
 * Project Purpose: Hilarious program to generate equally hilarious jokes.
 * Input:  This program does not accept inputs
 * Desired Output:  The label on the form should show the joke and a message box should pop up with the punchline
 * Variables and Classes: strings for all the jokes and punchlines because I don't know how to do arrays yet =(,
 *          joke counter to keep track of what order to do the jokes in
 * Formulas: N/A
 * Description of the main algorithm: The label is filled with the text based on a switch statement and the
 *          message box is filled based on the same counter. The counter, when reaching the end of the list of jokes
 *          (currently hardcoded) is reset to the starting point so the program loops until the user exits manually.

 * Testing:  Clicking the buttons should cause the desired output to occur. The jokes should make logical sense
 *          (meaning joke1 does not make sense with punchline 3).
 * 
 * January 25, 2016
 */

namespace InClassExerciseTwo
{
    public partial class formJokeGenerator : Form
    {
        string joke1 = "How many programmers does it take to screw in a lightbulb?";
        string joke2 = "Why do programmers always mix up Halloween and Christmas?";
        string joke3 = "What's the difference between an enterprise software salesperson and a used car dealer?";

        string punchline1 = "None. That's a hardware problem.";
        string punchline2 = "Because Oct 31 == Dec 25";
        string punchline3 = "The used car dealer knows when he's lying.";

        int jokeCounter = 0;

        public formJokeGenerator()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            lblJoke.Text = string.Empty;
            if(jokeCounter == 3)
            {
                jokeCounter = 0;
            }
            switch(jokeCounter + 1)
            {
                case 1:
                    lblJoke.Text = joke1;
                    break;
                case 2:
                    lblJoke.Text = joke2;
                    break;
                case 3:
                    lblJoke.Text = joke3;
                    break;
            }
            jokeCounter++;
        }

        private void btnPunchline_Click(object sender, EventArgs e)
        {
            switch (jokeCounter)
            {
                case 1:
                    MessageBox.Show(punchline1);
                    break;
                case 2:
                    MessageBox.Show(punchline2);
                    break;
                case 3:
                    MessageBox.Show(punchline3);
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've made the right choice!");
            this.Close();
        }
    }
}
