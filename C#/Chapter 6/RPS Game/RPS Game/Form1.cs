using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//jake gudenkauf
namespace RPS_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        //variables
        int rock;
        int paper;
        int scissors;
        int num;

        private void ComputersChoice()
        {
            //in form load comp decides which to choose
            Random rand = new Random();
            num = rand.Next(3) + 1;

            if (num == 1)
            {
                rock = 1;
            }
            else if (num == 2)
            {
                paper = 2;
            }
            else if (num == 3)
            {
                scissors = 3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rockwins()
        {
            rock = 1;
            if (num == 2)
            {
                MessageBox.Show("Computer chose PAPER, You Lost!");
            }
            else if (num == 3)
            {
                MessageBox.Show("Computer chose SCISSORS, You Win!");
            }
            else if (num == 1)
            {
                MessageBox.Show("Try Again, Computer chose ROCK also");
            }
        }

        private void paperwins()
        {
            paper = 2;
            if (num == 3)
            {
                MessageBox.Show("Computer chose SCISSORS, You Lost!");
            }
            else if (num == 1)
            {
                MessageBox.Show("Computer chose ROCK, You Win!");
            }
            else if (num == 2)
            {
                MessageBox.Show("Try Again, Computer chose PAPER also");
            }
        }

        private void scissorswins()
        {
            scissors = 3;
            if (num == 1)
            {
                MessageBox.Show("Computer chose ROCK, You Lost!");
            }
            else if (num == 2)
            {
                MessageBox.Show("Computer chose PAPER, You Win!");
            }
            else if (num == 3)
            {
                MessageBox.Show("Try Again, Computer chose SCISSORS also");
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            //chooses rock
            ComputersChoice();
            rockwins();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //chooses paper
            ComputersChoice();
            paperwins();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            //chooses scissors
            ComputersChoice();
            scissorswins();
        }
    }
}
