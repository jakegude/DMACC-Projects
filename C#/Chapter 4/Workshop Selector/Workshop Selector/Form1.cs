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
namespace Workshop_Selector
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            outputLabel.Text = "";
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates registration fees and lodging fees
            //variables
            string workshop, city;
            int days, registration, lodging;
            days = 0;
            registration = 0;
            lodging = 0;
            if ((workshopListbox.SelectedIndex != -1) && (cityListbox.SelectedIndex != -1))
            {
                workshop = workshopListbox.SelectedItem.ToString().Substring(0, 2);
                city = cityListbox.SelectedItem.ToString().Substring(0, 2);
                switch (workshop)
                {
                    case "Ha": days = 3; registration = 1000; break;
                    case "Ti": days = 3; registration = 800; break;
                    case "Su": days = 3; registration = 1500; break;
                    case "Ne": days = 5; registration = 1300; break;
                    case "Ho": days = 1; registration = 500; break;
                }
                switch (city)
                {
                    case "Au": lodging = 150; break;
                    case "Ch": lodging = 225; break;
                    case "Da": lodging = 175; break;
                    case "Or": lodging = 300; break;
                    case "Ph": lodging = 175; break;
                    case "Ra": lodging = 150; break;
                }
                
                //display
                outputLabel.Text = "Registration: $" + registration + "\n" +
                    "Lodging: $" + lodging + " x " + days + " Days = " + (lodging * days) + "\n" +
                    "Total: $" + (registration + lodging * days);
            }
            else
            {
                MessageBox.Show("Select a Workshop & Location");
            }
        }
    }
}
