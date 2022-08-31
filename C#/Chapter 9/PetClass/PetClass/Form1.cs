using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClass
{
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //oops
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet();
            getPetData(myPet);

            outputLabel.Text = "Name: " + myPet.Name + "\n" +
                               "Type: " + myPet.Type + "\n" +
                               "Age: " + myPet.Age.ToString();
        }
        private void getPetData(Pet pet)
        {
            try
            {
                pet.Name = nameTextbox.Text;
                pet.Type = typeTextbox.Text;
                int age;
                if (int.TryParse(ageTextbox.Text, out age))
                {
                    pet.Age = age;
                }
                else
                {
                    MessageBox.Show("Invalid Age");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
