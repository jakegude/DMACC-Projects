using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    class CompSciStudent : Students
    {
        //constants
        private double MATHHOURS = 20;
        private double CSHOURS = 40;
        private double GENHOURS = 60;

        //fields
        private string _academicTrack;

        //constructor
        public CompSciStudent (string name, string id, string track)
            : base(name, id)
        {
            _academicTrack = track;
        }

        //academic track prop
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        //required hours prop
        public override double RequiredHours
        {
            get { return MATHHOURS + CSHOURS + GENHOURS; }
        }
    }
}
