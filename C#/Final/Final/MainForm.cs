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
namespace Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            nameTextbox.Text = "";
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            nonhumanCheckbox.Checked = false;
            //focus
            nameTextbox.Focus();
        }

        public string gender;
        public string nonhuman;

        private void getButton_Click(object sender, EventArgs e)
        {
            //when done creating character, msg box will pop up with details
            //name
            string name = nameTextbox.Text;
            //gender
            if (maleRadio.Checked)
            {
                gender = "He";
            }
            else if (femaleRadio.Checked)
            {
                gender = "She";
            }
            //nonhuman
            if (nonhumanCheckbox.Checked)
            {
                Non_Human myNon_Human = new Non_Human();
                myNon_Human.ShowDialog();
                nonhuman = "Yes";
            }
            else
            {
                nonhuman = "No";
            }
            //skill set
            string skillset;
            if (skillsetListbox.SelectedIndex != -1)
            {
                skillset = skillsetListbox.SelectedItem.ToString().Substring(0, 2);
                switch (skillset)
                {
                    case "Wa":
                        skillset =
                    "\t" + "Strength: 8" + "\n" +
                    "\t" + "Perception: 6" + "\n" +
                    "\t" + "Endurance: 4" + "\n" +
                    "\t" + "Charisma: 5" + "\n" +
                    "\t" + "Intelligence: 4" + "\n" +
                    "\t" + "Agility: 4" + "\n" +
                    "\t" + "Luck: 5"; break;
                    case "Ma":
                        skillset =
                    "\t" + "Strength: 5" + "\n" +
                    "\t" + "Perception: 8" + "\n" +
                    "\t" + "Endurance: 5" + "\n" +
                    "\t" + "Charisma: 3" + "\n" +
                    "\t" + "Intelligence: 8" + "\n" +
                    "\t" + "Agility: 3" + "\n" +
                    "\t" + "Luck: 5"; break;
                    case "So":
                        skillset =
                    "\t" + "Strength: 6" + "\n" +
                    "\t" + "Perception: 6" + "\n" +
                    "\t" + "Endurance: 8" + "\n" +
                    "\t" + "Charisma: 7" + "\n" +
                    "\t" + "Intelligence: 5" + "\n" +
                    "\t" + "Agility: 3" + "\n" +
                    "\t" + "Luck: 5"; break;
                    case "He":
                        skillset =
                    "\t" + "Strength: 10" + "\n" +
                    "\t" + "Perception: 10" + "\n" +
                    "\t" + "Endurance: 10" + "\n" +
                    "\t" + "Charisma: 10" + "\n" +
                    "\t" + "Intelligence: 10" + "\n" +
                    "\t" + "Agility: 10" + "\n" +
                    "\t" + "Luck: 10"; break;
                    case "Vi":
                        skillset =
                    "\t" + "Strength: 10" + "\n" +
                    "\t" + "Perception: 10" + "\n" +
                    "\t" + "Endurance: 10" + "\n" +
                    "\t" + "Charisma: 10" + "\n" +
                    "\t" + "Intelligence: 10" + "\n" +
                    "\t" + "Agility: 10" + "\n" +
                    "\t" + "Luck: 0"; break;
                }
                //write data to file
                try
                {
                    StreamWriter outputfile;
                    outputfile = File.AppendText("Characters.txt");
                    outputfile.WriteLine("Name:" + "\t" +
                            "Gender:" + "\t" +
                            "Non-Human:" + "\t" + 
                            "Skill Set:");
                    outputfile.WriteLine(name.ToString() + "\t" +
                    gender.ToString() + "\t" +
                    nonhuman.ToString() + "\t" + "\t" +
                    skillsetListbox.SelectedItem.ToString());
                    outputfile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //display
                MessageBox.Show("You made " + name.ToString() + "!" + "\n" + 
                    "Non-Human: " + nonhuman + "\n" + 
                    gender + "'s a " + skillsetListbox.SelectedItem.ToString() + "!" + "\n" +
                    "With a skill set of: " + "\n" + skillset.ToString());
            }
        }
    }
}
