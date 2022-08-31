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
namespace Ocean_Level
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //calculates ocean level after 10 years at form load
            double risen, count;

            count = 1;
            listBox1.Items.Add("In _ Years\tRisen");

            while (count <= 10)
                {
                    risen = count * 1.5;
                    listBox1.Items.Add(count + "\t\t" + risen + "mm");
                    count ++;
                }
        }
    }
}
