using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class NonHumanClass
    {
        public string _orc, _elf, _hobbit, _wookie;

        public NonHumanClass()
        {
            _orc = "";
            _elf = "";
            _hobbit = "";
            _wookie = "";
        }
        public string orc
        {
            get { return _orc; }
            set { _orc = value; }
        }
        public string elf
        {
            get { return _elf; }
            set { _elf = value; }
        }
        public string hobbit
        {
            get { return _hobbit; }
            set { _hobbit = value; }
        }
        public string wookie
        {
            get { return _wookie; }
            set { _wookie = value; }
        }
    }
}
