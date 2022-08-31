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
//jake gudenkauf
namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        //200 boys and 200 girls names

        private void searchButton_Click(object sender, EventArgs e)
        {
            int boyname, girlname;
            try
            {
            //create array for girls names
            const int SIZE = 200;
            string[] girls = new string[SIZE];
            //counter variable
            int i = 0;
            //stream reader
            StreamReader inputfile;
            inputfile = File.OpenText("GirlNames.txt");
            //read the file contents
            while (i < girls.Length && !inputfile.EndOfStream)
            {
                girls[i] = (inputfile.ReadLine());
                i++;
            }
                //close the file
                inputfile.Close();
            if (int.TryParse(girlsTextbox.Text, out girlname))
            {
                MessageBox.Show("Your name is in the most popular list!");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
            //create array for boys names
            const int SIZE = 200;
            string[] boys = new string[SIZE];
            //counter variable
            int i = 0;
            //stream 
            StreamReader inputfile;
            inputfile = File.OpenText("BoyNames.txt");
            //read the file contents
            while (i < boys.Length && !inputfile.EndOfStream)
            {
                boys[i] = (inputfile.ReadLine());
                i++;
            }
            //close the file
            inputfile.Close();
            if (int.TryParse(boysTextbox.Text, out boyname))
            {
                MessageBox.Show("Your name is in the most popular list!");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
