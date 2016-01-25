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
 * Input:  Button click inputs handled by local methods
 * Desired Output:  The label on the form should show the joke and a message box should pop up with the punchline
 * Variables and Classes: string arrays for the jokes and punchlines allow easy expansion,
 *          joke counter to keep track of which joke number is current
 * Formulas: N/A
 * Description of the main algorithm: The label is populated based on a counter and getting the array index at the counter
 *          position
 * Testing:  Clicking the buttons should cause the desired output to occur. The jokes should make logical sense
 *          (meaning joke1 does not make sense with punchline 3).
 * 
 * January 25, 2016
 */

namespace InClassExerciseTwo
{
    public partial class formJokeGenerator : Form
    {
        //Easily expandable array of jokes, simply add new line
        string[] jokes = 
        {
            "How many programmers does it take to screw in a lightbulb?",
            "Why do programmers always mix up Halloween and Christmas?",
            "What's the difference between an enterprise software salesperson and a used car dealer?"
        };

        //Equally easily expandable array of punchlines. Should correspond to the index of the joke
        string[] punchlines = 
        {
            "None. That's a hardware problem.",
            "Because Oct 31 == Dec 25",
            "The used car dealer knows when he's lying."
        };

        int jokeCounter = 0; //Joke Counter to keep track of current joke number

        public formJokeGenerator()
        {
            InitializeComponent();
        }

        //Sets up the joke based on joke counter
        private void btnSetup_Click(object sender, EventArgs e)
        {
            lblJoke.Text = jokes[jokeCounter];
        }
        
        //Shows a message box with the punchline corresponding to the joke counter then clears counter if at max index
        private void btnPunchline_Click(object sender, EventArgs e)
        {
            MessageBox.Show(punchlines[jokeCounter]);
            jokeCounter++;
            if (jokeCounter == jokes.Length)
            {
                jokeCounter = 0;
            }
        }

        //Exits the program after displaying another HILARIOUS joke.
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've made the right choice!");
            this.Close();
        }
    }
}
