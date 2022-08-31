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
namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            speedTextbox.Text = string.Empty;
            hoursTextbox.Text = string.Empty;
            distanceListbox.Items.Clear();

            //focus
            speedTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates distance you will be traveling at inputted speed
            //variables
            double mph, MAXVALUE;

            if (double.TryParse(speedTextbox.Text, out mph) &&
                (double.TryParse(hoursTextbox.Text, out MAXVALUE)))
            {
                double count = 1.0;
                distanceListbox.Items.Clear();

                while(count <= MAXVALUE)
                {
                    distanceListbox.Items.Add("After Hour " + count + " the distance is " +
                        mph * count);
                    count ++;
                }
            }
            
        }
    }
}
