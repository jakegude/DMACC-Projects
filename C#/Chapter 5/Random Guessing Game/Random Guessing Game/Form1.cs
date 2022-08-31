using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //calculate 2 random numbers to equal inputted answer
            //variable

            int guess, num;
            int.TryParse(guessTextbox.Text, out guess);

            Random rand = new Random();
            num = rand.Next(99) + 1;

            if (guess == num)
            {
                MessageBox.Show("Congratulations! You Won!");
            }
            else if (guess < num)
            {
                MessageBox.Show("Too Low! Answer is: " + num);
            }
            else if (guess > num)
            {
                MessageBox.Show("Too High! Answer is: " + num);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }
    }
}
