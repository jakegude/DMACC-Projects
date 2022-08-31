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
namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                string[] lines = new string[SIZE];
                double total = 0;
                StreamReader inputfile;
                inputfile = File.OpenText("Sales.txt");
                int index = 0;
                while (index < lines.Length && !inputfile.EndOfStream)
                {
                    lines[index] = inputfile.ReadLine();
                    index++;
                }
                inputfile.Close();
                foreach (string str in lines)
                {
                    listBox1.Items.Add(str);
                    total += double.Parse(str);
                }
                double max, min;
                max = double.Parse(lines[0]);
                for (int i = 1; i < SIZE; i++)
                {
                    if (double.Parse(lines[i]) > max)
                    {
                        max = double.Parse(lines[i]);
                    }
                }
                min = double.Parse(lines[0]);
                for (int i = 1; i > SIZE; i++)
                {
                    if (double.Parse(lines[i]) > min)
                    {
                        min = double.Parse(lines[i]);
                    }
                }
                outputLabel.Text = "The Total is: " + total.ToString("C") + "\n" +
                    "The largest value is: " + max.ToString("c") + "\n" +
                    "The smallest value is: " + min.ToString("c") + "\n" +
                    "The average is: " + (total / SIZE).ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}