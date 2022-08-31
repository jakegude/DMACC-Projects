using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car myCar = new Car(1967, "Ford", "Fusion");

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            myCar.Accelerate();
            outputLabel.Text = "The speed of " + myCar.Year + " " + myCar.Make +
                " " + myCar.Model + " is " + myCar.Speed + "MPH";
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            myCar.Brake();
            outputLabel.Text = "The speed of " + myCar.Year + " " + myCar.Make +
                " " + myCar.Model + " is " + myCar.Speed + "MPH";
        }
    }
}
