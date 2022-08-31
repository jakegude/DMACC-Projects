using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            //loads numbers
            Random rand = new Random();
            int n1, n2, ans;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //oops
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculate
            if (int.TryParse(answerTextbox.Text, out ans))
            {
                if (ans == n1 + n2)
                {
                    MessageBox.Show("Congratulations! You won!");
                }
                else
                {
                    MessageBox.Show("Haha, You lost! The answer is: " + (n1 + n2));
                }
                getNumber();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getNumber();
        }

        public void getNumber()
        {
            //load random numbers
            answerTextbox.Text = "";
            n1 = rand.Next(99, 500) + 1;
            n2 = rand.Next(99, 500) + 1;
            num1Label.Text = n1.ToString();
            num2Label.Text = n2.ToString();
        }
    }
}
