using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Coin_Toss
{
    class coin
    {
        //field to represent the side facing up
        private string sideUp;
        Random rand = new Random();

        //constructor
        public coin()
        {
            sideUp = "Heads";
        }

        //the toss method simulates the coin
        public void toss()
        {
            //creat a random object
            //Random rand = new Random();

            //use a random number to determine the side of teh coin is facing up
            //0 = Heads, 1 = Tails;
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        
        //the getsideup method returns the value of the sideUp field
        public string GetSideUp()
        {
            return sideUp;
        }
    }
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

        private void tossButton_Click(object sender, EventArgs e)
        {
            //create a coin obj
            coin mycoin = new coin();

            //clear the listbox
            outputListBox.Items.Clear();

            //toss the coin 5 times
            for (int count = 0; count < 5; count++)
            {
                //toss the coin
                mycoin.toss();

                //display the side that is up
                outputListBox.Items.Add(mycoin.GetSideUp());
            }
        }
    }
}
