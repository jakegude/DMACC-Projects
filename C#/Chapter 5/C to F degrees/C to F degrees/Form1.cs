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
namespace C_to_F_degrees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //displays c to f between 0 n 20 degrees
            //variables
            double f, c;

            c = 0;
            listBox1.Items.Add("Celsius\tFahrenheit");

            while (c <= 20)
            {
                f = ((9 * c) / 5) + 32;
                listBox1.Items.Add(c + "\t" + f);
                c ++;
            }
        }
    }
}
