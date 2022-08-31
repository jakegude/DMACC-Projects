using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_And_Punch_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            deliveryLabel.Text = "Your moms fat";
        }

        private void punchlineButton_Click(object sender, EventArgs e)
        {
            deliveryLabel.Text = "Yo momma so fat, she sat on Wal-Mart and lowered the prices";
        }
    }
}
