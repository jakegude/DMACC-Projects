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
//roman numeral converter 1-10
namespace Roman_Numeral_Convertor
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
            numberTextbox.Text = string.Empty;

            //set focus
            numberTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //converts the inputted number to a roman numeral
            //variable
            int romannum;
            //convert
            if (int.TryParse(numberTextbox.Text, out romannum))
            {
                if (romannum < 1 || romannum > 10)
                {
                    MessageBox.Show("Out of range or incalid input");
                }
                else
                {
                    string str = "";
                    switch (romannum)
                    {
                        case 1: str = "I"; break;
                        case 2: str = "II"; break;
                        case 3: str = "III"; break;
                        case 4: str = "IV"; break;
                        case 5: str = "V"; break;
                        case 6: str = "VI"; break;
                        case 7: str = "VII"; break;
                        case 8: str = "VIII"; break;
                        case 9: str = "IX"; break;
                        case 10: str = "X"; break;
                    }
                    //display
                    MessageBox.Show("Roman Numeral Version is " + str);
                }
            }
        }
    }
}
