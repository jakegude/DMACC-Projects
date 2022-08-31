using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    abstract class Students
    {
        //fields
        private string _name;
        private string _id;

        //constructor
        public Students (string name, string id)
        {
            _name = name;
            _id = id;
        }

        //name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //id property
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //required hour propety (abstract
        public abstract double RequiredHours
        {
            get;
        }
    }
}
