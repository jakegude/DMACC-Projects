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
//distance converter
namespace Distance_Converter
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

        private void convertButton_Click(object sender, EventArgs e)
        {
            //converts selected distances
            //variables
            double distance = double.Parse(distanceTextbox.Text);
            string from, to;

            if (fromListbox.SelectedIndex != -1 && toListbox.SelectedIndex != -1)
            {
                from = fromListbox.SelectedItem.ToString();
                to = toListbox.SelectedItem.ToString();
                
                if (from == to)
                {
                    resultLabel.Text = distance.ToString();
                }
                else if (from == "Yards" && to == "Feet")
                {
                    resultLabel.Text = (distance * 3).ToString();
                }
                else if (from == "Feet" && to == "Yards")
                {
                    resultLabel.Text = (distance / 3).ToString();
                }
                else if (from == "Yards" && to == "Inches")
                {
                    resultLabel.Text = (distance * 36).ToString();
                }
                else if (from == "Inches" && to == "Yards")
                {
                    resultLabel.Text = (distance / 36).ToString();
                }
                else if (from == "Feet" && to == "Inches")
                {
                    resultLabel.Text = (distance * 12).ToString();
                }
                else if (from == "Inches" &&  to == "Feet")
                {
                    resultLabel.Text = (distance / 12).ToString();
                }
            }
        }
    }
}
