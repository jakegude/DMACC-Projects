using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//jake gudenkauf
namespace Joes_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void ClearOilLube()
        {
            //clears oil change and lube job boxes
            oilchangeCheckbox.Checked = false;
            lubejobCheckbox.Checked = false;
        }

        private void ClearFlushes()
        {
            //clears flushes
            radiatorflushCheckbox.Checked = false;
            transmissionflushCheckbox.Checked = false;
        }

        private void ClearMisc()
        {
            //clear misc
            inspectionCheckbox.Checked = false;
            replacemufflerCheckbox.Checked = false;
            tirerotateCheckbox.Checked = false;
        }

        private void ClearOther()
        {
            //clears other
            partTextbox.Text = "";
            laborTextbox.Text = "";
        }

        private void ClearFees()
        {
            //clears extra fees
            serviceLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears form
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        //variables
        double oil, lube, radiator, transmission, inspection, muffler, tire, parts,
            labor, tax;

        private void OilLubeCharges()
        {
            //oil and lube calculations
            if (oilchangeCheckbox.Checked)
            {
                oil = 26;
            }
            else
            {
                oil = 0;
            }

            if (lubejobCheckbox.Checked)
            {
                lube = 18;
            }
            else
            {
                lube = 0;
            }
        }

        private void FlushCharges()
        {
            //flush calculations
            if (radiatorflushCheckbox.Checked)
            {
                radiator = 30;
            }
            else
            {
                radiator = 0;
            }
            
            if (transmissionflushCheckbox.Checked)
            {
                transmission = 80;
            }
            else
            {
                transmission = 0;
            }
        }

        private void MiscCharges()
        {
            //misc calculations
            if (inspectionCheckbox.Checked)
            {
                inspection = 15;
            }
            else
            {
                inspection = 0;
            }

            if (replacemufflerCheckbox.Checked)
            {
                muffler = 100;
            }
            else
            {
                muffler = 0;
            }

            if (tirerotateCheckbox.Checked)
            {
                tire = 20;
            }
            else
            {
                tire = 0;
            }
        }

        private void OtherCharges()
        {
            //other calculations
            if (double.TryParse(partTextbox.Text, out parts))
            {
                partsLabel.Text = parts.ToString("C2");
            }
            else
            {
                partsLabel.Text = "$0.00";
            }

            if ((double.TryParse(laborTextbox.Text, out labor)))
            {
                serviceLabel.Text = labor.ToString("C2");
            }
            else
            {
                serviceLabel.Text = "$0.00";
            }
        }

        private void TaxCharges()
        {
            //calculates tax
            tax = 0.06;
            taxLabel.Text = (tax * parts).ToString("C2");
        }

        private void Totalcharges()
        {
            //calculates total label
            totalLabel.Text = (oil + lube + radiator + transmission + inspection + muffler + tire + parts
                + labor + tax).ToString("C2");
        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            //calculates the total cost of work
            OilLubeCharges();
            FlushCharges();
            MiscCharges();
            OtherCharges();
            TaxCharges();
            Totalcharges();
        }
    }
}