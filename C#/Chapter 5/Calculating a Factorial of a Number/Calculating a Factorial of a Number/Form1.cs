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
namespace Calculating_a_Factorial_of_a_Number
{
    public partial class Factorial : Form
    {
        public Factorial()
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
            numTextbox.Text = "";
            //focus
            numTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the factorial of inputted number
            //variables
            int num = int.Parse(numTextbox.Text);
            int factorial = 1;
            for (int count = 1; count <= num; count++)
            {
                factorial *= count;
            }
            MessageBox.Show(factorial.ToString());
        }
    }
}