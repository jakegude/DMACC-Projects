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
namespace Time_Zone_Selector
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

        private void okButton_Click(object sender, EventArgs e)
        {
            //finds timezone for selected city
            string city;

            if (cityListbox.SelectedIndex != -1)
            {
                city = cityListbox.SelectedItem.ToString();

                switch (city)
                {
                    case "Honolulu":
                        timezoneLabel.Text = "Hawaii-Aleutian"; break;
                    case "San Fransico":
                        timezoneLabel.Text = "Pacific"; break;
                    case "Denver":
                        timezoneLabel.Text = "Mountain"; break;
                    case "Minneapolis":
                        timezoneLabel.Text = "Central"; break;
                    case "New York":
                        timezoneLabel.Text = "Eastern"; break;
                }
            }
            else
            {
                MessageBox.Show("Select a city");
            }
        }
    }
}
