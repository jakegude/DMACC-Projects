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
namespace Addition_Tutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //oops
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            answerTextbox.Text = "";

            //focus
            answerTextbox.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            //calculate 2 random numbers to equal inputted answer
            //variable
            
            int answer, num;
            int.TryParse(answerTextbox.Text, out answer);

            Random rand = new Random();
            num = rand.Next(99) + 1;

            if (answer == num)
            {
                MessageBox.Show("Congratulations! You Won!");
            }
            else if (num < answer)
            {
                MessageBox.Show("Too Low! Answer is: " + answer);
            }
            else if (num > answer)
            {
                MessageBox.Show("Too High! Answer is: " + answer);
            }
        }
    }
}
