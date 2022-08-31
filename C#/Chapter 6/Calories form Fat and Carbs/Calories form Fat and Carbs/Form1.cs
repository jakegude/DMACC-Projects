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
namespace Calories_form_Fat_and_Carbs
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the form
            fatgramsTextbox.Text = "";
            carbgramsTextbox.Text = "";
            outputLabel.Text = "";
            //focus
            fatgramsTextbox.Focus();
        }

        private double FatCalories(double fat)
        {
            //fat cal formula
            return (fat * 9);
        }

        private double CarbCalories(double carb)
        {
            //carb cal formula
            return (carb * 4);
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates cals form fat and carbs
            double fat, carb;

            if (double.TryParse(fatgramsTextbox.Text, out fat) &&
                (double.TryParse(carbgramsTextbox.Text, out carb)))
            {
                outputLabel.Text = "Calories from Fat: " + FatCalories(fat) + "\n" +
                    "Calories from Carbs: " + CarbCalories(carb);
            }
        }
    }
}