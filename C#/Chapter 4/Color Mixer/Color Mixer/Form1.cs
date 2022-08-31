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
//color mixer
//1-31-2017
namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits the program
            this.Close();

        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            //mixes the selected colors
            if (firstredRadiobutton.Checked && secondredRadiobutton.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (firstblueRadiobutton.Checked && secondblueRadiobutton.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (firstyellowRadioButton.Checked && secondyellowRadiobutton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if ((firstredRadiobutton.Checked && secondblueRadiobutton.Checked)
                || firstblueRadiobutton.Checked && secondredRadiobutton.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if ((firstredRadiobutton.Checked && secondyellowRadiobutton.Checked)
                || firstyellowRadioButton.Checked && secondredRadiobutton.Checked)
                {
                this.BackColor = Color.Orange;
                } 
            else if ((firstblueRadiobutton.Checked && secondyellowRadiobutton.Checked) 
                || firstyellowRadioButton.Checked && secondblueRadiobutton.Checked)
                {
                this.BackColor = Color.Green;
                }
        }
        }
}
