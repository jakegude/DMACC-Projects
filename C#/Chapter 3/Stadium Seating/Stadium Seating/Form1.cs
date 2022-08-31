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
//stadium seating
namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //oops
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears inputs and outputs
            AseatsTextbox.Text = string.Empty;
            BseatsTextbox.Text = string.Empty;
            CseatsTextbox.Text = string.Empty;
            ArevenueLabel.Text = string.Empty;
            BrevenueLabel.Text = string.Empty;
            CrevenueLabel.Text = string.Empty;
            totalLabel.Text = string.Empty;

            //focus
            AseatsTextbox.Focus();

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the revenue
            //variables
            int aSeats = int.Parse(AseatsTextbox.Text);
            int bSeats = int.Parse(BseatsTextbox.Text);
            int cSeats = int.Parse(CseatsTextbox.Text);
            int aRevenue = aSeats * 15;
            int bRevenue = bSeats * 12;
            int cRevenue = cSeats * 9;
            int total = aRevenue + bRevenue + cRevenue;

            //display
            ArevenueLabel.Text = aRevenue.ToString("C2");
            BrevenueLabel.Text = bRevenue.ToString("C2");
            CrevenueLabel.Text = cRevenue.ToString("C2");
            totalLabel.Text = total.ToString("C2");


        }
    }
}
