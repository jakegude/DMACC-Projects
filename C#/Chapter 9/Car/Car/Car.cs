using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private int _year;
        private string _make;
        private string _model;
        private double _speed;

        public Car(int year, string make, string model)
        {
            _year = 0;
            _make = make;
            _model = model;
            _speed = 0;
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            if (Speed <= 0)
            {
                Speed = 0;
            }
            else
            {
                Speed -= 5;
            }
        }
    }
}