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
namespace Pennies_for_Pay
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
            //clears form
            daysTextbox.Text = "";
            listBox1.Items.Clear();

            //focus
            daysTextbox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //claculates how much money you will have after x days
            //variables
            double days , count;

            if (double.TryParse(daysTextbox.Text, out days))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Day\tPennies");
                count = 1;
                while (count <= days)
                {
                    listBox1.Items.Add(count + "\t" + Math.Pow(2, count - 1));
                    count ++;
                }
            }

        }
    }
}
