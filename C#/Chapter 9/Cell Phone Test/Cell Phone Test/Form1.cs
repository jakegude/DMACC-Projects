using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//jake gudenkauf
namespace Cell_Phone_Test
{
    class cellphone
    {
        //fields
        private string _brand; //the phones brand
        private string _model; //the phones model
        private decimal _price; //the phones price

        //constructor
        public cellphone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //model prop
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //price prop
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
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

        //the GetPhoneData method accepts a cellphone object as an argument
        //it assigns the data entered by the user to the objects properties
        private void GetPhoneData(cellphone phone)
        {
            //temporary variable to hold the price 
            decimal price;

            //get the phones brand
            phone.Brand = brandTextBox.Text;

            //get the phones model
            phone.Model = modelTextBox.Text;

            //get the phones price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                //display an error message
                MessageBox.Show("Invalid price");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //creat a cellphone object
            cellphone myphone = new cellphone();

            //get the phone data
            GetPhoneData(myphone);

            //display data
            brandLabel.Text = myphone.Brand;
            modelLabel.Text = myphone.Model;
            priceLabel.Text = myphone.Price.ToString("c");
        }
    }
}
