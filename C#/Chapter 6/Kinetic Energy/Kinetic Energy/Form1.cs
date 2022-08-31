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
namespace Kinetic_Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits the program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the form
            massTextbox.Text = "";
            velocityTextbox.Text = "";
            outputLabel.Text = "";
            //focus
            outputLabel.Focus();
        }

        private void KineticEnergy(double mass, double velocity)
        {
            //display
            outputLabel.Text = "Kinetic Energy: " + (0.5 * mass * Math.Pow(velocity, 2)).ToString();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the KE of an obj
            //variables
            double mass;
            double velocity;

            if (double.TryParse(massTextbox.Text, out mass) && 
               (double.TryParse(velocityTextbox.Text, out velocity)))
            {
                KineticEnergy(mass, velocity);
            }
        }
    }
}
