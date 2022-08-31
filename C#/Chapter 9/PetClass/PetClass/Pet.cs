﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClass
{
    class Pet
    {
        private string _name;
        private string _type;
        private int _age;

        public Pet()
        {
            _name = "";
            _type = "";
            _age = 0;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
    }
}
