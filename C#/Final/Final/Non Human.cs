using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public partial class Non_Human : Form
    {
        public Non_Human()
        {
            InitializeComponent();
        }

        private void Non_Human_Load(object sender, EventArgs e)
        {

        }
        //non human radio buttons
        public string gender;
        public string nonhuman;

        private void returnButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        public void nonhumanMethod()
        {
            if (orcRadio.Checked)
            {
                gender = "It";
                nonhuman = "Orc";
            }
            else if (dwarfRadio.Checked)
            {
                gender = "It";
                nonhuman = "Dwarf";
            }
            else if (hobbitRadio.Checked)
            {
                gender = "It";
                nonhuman = "Hobbit";
            }
            else if (wookieRadio.Checked)
            {
                gender = "It";
                nonhuman = "Wookie";
            }
            else
            {
                nonhuman = "Human";
            }
        }

        public void orcRadio_CheckedChanged(object sender, EventArgs e)
        {
            //oops
        }

        public void dwarfRadio_CheckedChanged(object sender, EventArgs e)
        {
            //oops
        }

        public void hobbitRadio_CheckedChanged(object sender, EventArgs e)
        {
            //oops
        }

        public void wookieRadio_CheckedChanged(object sender, EventArgs e)
        {
            //oops
        }
    }
}
