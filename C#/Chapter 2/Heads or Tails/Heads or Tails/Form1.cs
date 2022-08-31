using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
            //closes the program
        {
            this.Close();
        }

        private void headsButton_Click(object sender, EventArgs e)
        //shows only heads
        {
            headsPicturebox.Visible = true;
            tailsPicturebox.Visible = false;

        }

        private void tailsButton_Click(object sender, EventArgs e)
        //shows only tails
        {
            headsPicturebox.Visible = false;
            tailsPicturebox.Visible = true;

        }
    }
}
