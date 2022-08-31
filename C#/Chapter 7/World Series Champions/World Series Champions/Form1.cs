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
namespace World_Series_Champions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double wins;
        double teams;

        private void Form1_Load(object sender, EventArgs e)
        {
            readteams(teams);
            readwinners(wins);
        }

        private void readwinners(List<double> winsList)
        {
            try
            {
                StreamReader inputfile;
                inputfile = File.OpenText("WorldSeriesWinners.txt");

                while (!inputfile.EndOfStream)
                {
                    winsList.Add(int.Parse(inputfile.ReadLine()));
                }

                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readteams(List<double> winsList)
        {
            //loads teams into listbox
            try
            {
                const int SIZE = 29;
                string[] teams = new string[SIZE];

                StreamReader inputfile;
                inputfile = File.OpenText("Teams.txt");
                
                int index = 0;
                while (index < teams.Length && !inputfile.EndOfStream)
                {
                    teams[index] = inputfile.ReadLine();
                    index++;
                }
                inputfile.Close();

                foreach (string str in teams)
                {
                    teamsListbox.Items.Add(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teamsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (double i = 0; i < wins; i++)
            {
                MessageBox.Show(teams + "has won the World Series " 
                    + wins + " times since 1903.");
            }
        }
    }
}
