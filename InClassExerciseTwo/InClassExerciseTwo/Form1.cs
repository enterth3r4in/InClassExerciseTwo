using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
