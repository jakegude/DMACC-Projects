using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;  //needed for message box

namespace Polymorphism
{
    class Cat : Animal
    {
        //field
        private string _name;

        //constructor
        public Cat(string name)
            : base("Cat")
        {
            _name = name;
        }

        //species propety
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //make sound method
        public override void MakeSound()
        {
            MessageBox.Show("Meow!");
        }
    }
}
