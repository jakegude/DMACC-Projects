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
namespace Charge_Account_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SIZE = 18;
        string[] account = new string[SIZE];

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputfile;
                inputfile = File.OpenText("ChargeAccounts.txt");
                int index = 0;
                while (index < account.Length && !inputfile.EndOfStream)
                {
                    account[index] = inputfile.ReadLine();
                    index++;
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            Boolean valid = false;
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] == textBox1.Text)
                {
                    valid = true; break;
                }
            }
                if (valid == true)
                {
                    MessageBox.Show("This is a valid Charge Account");
                }
                else
                {
                    MessageBox.Show("This is NOT a valid Charge Account");
                }
        }
    }
}