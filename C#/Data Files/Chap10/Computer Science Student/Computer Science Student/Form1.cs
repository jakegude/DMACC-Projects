using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //variables
            string name, id, track;

            //get the students name and id
            name = nameTextBox.Text;
            id = idTextBox.Text;

            //get the academic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //create a compscistudent obj
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //display
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }
    }
}
