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
namespace Prime_Numbers
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
            numberTextbox.Text = "";
            outputLabel.Text = "";
            //focus
            numberTextbox.Focus();
        }

        int num;
        bool evenodd;
        private bool IsPrime()
        {
            //tells whether num is even or odd

            if (num % 2 == 0)
            {
                evenodd = false;
            }
            else
            {
                evenodd = true;
            }
            return evenodd;
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculate
            IsPrime();
            int.TryParse(numberTextbox.Text, out num);
            outputLabel.Text = evenodd.ToString();
        }
    }
}
