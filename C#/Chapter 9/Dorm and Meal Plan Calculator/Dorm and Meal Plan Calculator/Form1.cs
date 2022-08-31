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
namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            allenhallRadiobutton.Checked = false;
            pikehallRadiobutton.Checked = false;
            farthinghallRadiobutton.Checked = false;
            suitesRadiobutton.Checked = false;
            sevenmealsRadiobutton.Checked = false;
            fourteenmealsRadiobutton.Checked = false;
            unlimitedmealsRadiobutton.Checked = false;
        }
            //variables
            int dormcharge, mealcharge, total;
        private void calcbutton_Click(object sender, EventArgs e)
        {
            //creates new form
            Form totalcharge = new Form();
            Label totalDormsLabel = new Label();
            totalDormsLabel.Location = new Point(10, 10);
            totalDormsLabel.Size = new Size(60, 50);
            Label totalMealsLabel = new Label();
            totalMealsLabel.Location = new Point(10, 60);
            totalMealsLabel.Size = new Size(60, 50);
            Label totalLabel = new Label();
            totalLabel.Location = new Point(10, 110);
            totalLabel.Size = new Size(60, 50);

            //dorms
            if (allenhallRadiobutton.Checked)
            {
                dormcharge = 1500;
            }
            else if (pikehallRadiobutton.Checked)
            {
                dormcharge = 1600;
            }
            else if (farthinghallRadiobutton.Checked)
            {
                dormcharge = 1800;
            }
            else if (suitesRadiobutton.Checked)
            {
                dormcharge = 2500;
            }

            //meals
            if (sevenmealsRadiobutton.Checked)
            {
                mealcharge = 600;
            }
            else if (fourteenmealsRadiobutton.Checked)
            {
                mealcharge = 1200;
            }
            else if (unlimitedmealsRadiobutton.Checked)
            {
                mealcharge = 1700;
            }

            totalDormsLabel.Text = "Total Dorm Charge: " + dormcharge.ToString("c2");
            totalMealsLabel.Text = "Total Meal Charge: " +mealcharge.ToString("c2");
            total = mealcharge + dormcharge;
            totalLabel.Text = "Total: " + total.ToString("c2");

            //display
            totalcharge.Controls.Add(totalDormsLabel);
            totalcharge.Controls.Add(totalMealsLabel);
            totalcharge.Controls.Add(totalLabel);
            totalcharge.ShowDialog();
        }
    }
}
