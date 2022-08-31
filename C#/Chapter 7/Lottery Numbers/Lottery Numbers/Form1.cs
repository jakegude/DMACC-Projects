using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //create an array to hold the number
            const int SIZE = 5;
            int[] loteryNumbers = new int[SIZE];

            //create a random object
            Random rand = new Random();

            //fill the array with random numbers in the range of 0 and 99
            for (int index = 0; index < loteryNumbers.Length; index++)
            {
                loteryNumbers[index] = rand.Next(100);
            }

            //display the array elements in the label controls
            firstLabel.Text = loteryNumbers[0].ToString();
            secondLabel.Text = loteryNumbers[1].ToString();
            thirdLabel.Text = loteryNumbers[2].ToString();
            fourthLabel.Text = loteryNumbers[3].ToString();
            fifthLabel.Text = loteryNumbers[4].ToString();
        }
    }
}
