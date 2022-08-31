using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//jake gudenkauf
namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
            //the average method accepts an int 
            //array argument and returns the average of the values in the array
        private double Average (int[] iArray)
        {
            int total = 0; //accumulator, initialized
            double average; //to hold the average
            //step through the array, adding each element to the accumulator
            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            //calculatre the average
            average = (double)total / iArray.Length;

            //return the avg
            return average;
        }

        //the highest method accepts an int array argument and returs the highest 
        //value in that array
        private int Highest (int[] iArray)
        {
            //declare a variable to hold the highest value and initialize it with
            //the first value in the array
            int highest = iArray[0];

            //step through the rest of the array beginning at element 1
            //when a value greater than highest is found assign that value to highest
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }
            //return the highest value
            return highest;
        }

        //the lowest method accepts an in array argument and 
        //returns the lowest value in that array
        private int Lowest (int[] iArray)
        {
            //declare a variable to hold the lowest value and 
            //initialize it with the first value in the array
            int lowest = iArray[0];

            //step through the rest of the array beginning at element 1.
            //when a value less than lowest is found assaing that value to lowest
            for (int index = 1; index < iArray.Length; index++)
            {
                lowest = iArray[index];
            }

            //return the lowest value
            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                //local variables
                const int SIZE = 5; //number of tests
                int[] scores = new int[SIZE]; // array of scores
                int index = 0; //loop counter
                int highest; //to hold the highest
                int lowest; //to hold lowest
                double averagescroe; //to hold avg scores
                StreamReader inputFile; //for file input

                //open the file and get a Streamreader obj
                inputFile = File.OpenText("TestScores.txt");

                //read the test scores into the array
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                //close the file
                inputFile.Close();

                //display the test scores
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                //get the highest lowest and average scores
                highest = Highest(scores);
                lowest = Lowest(scores);
                averagescroe = Average(scores);

                //display
                highScoreLabel.Text = highest.ToString();
                lowScoreLabel.Text = lowest.ToString();
                averageScoreLabel.Text = averagescroe.ToString();
            }

            catch (Exception ex)
            {
                //display an error
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }
    }
}
