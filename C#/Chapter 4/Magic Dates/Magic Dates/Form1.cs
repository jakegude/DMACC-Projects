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
//magic dates
//1-31-2017
namespace Magic_Dates
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
            //clears inputs and outputs
            monthTextbox.Text = string.Empty;
            dayTextbox.Text = string.Empty;
            yearTextbox.Text = string.Empty;

            //set focus
            monthTextbox.Focus();

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates if the date entered is magic
            //variables
            int month = int.Parse(monthTextbox.Text),
                day = int.Parse(dayTextbox.Text),
                year = int.Parse(yearTextbox.Text);

            if (month * day == year)
            {
                MessageBox.Show("The Date is Magic!");
            }
            else
            {
                MessageBox.Show("The Date is Not Magic");
            }
        }
    }
}
