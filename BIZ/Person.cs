using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string County { get; set; }

        public Person(string fn, string sn, string dob, string ge, string cy) 
        {
            Firstname = fn;
            Surname = sn;
            DOB = dob;
            Gender = ge;
            County = cy;       
        }

    }
}
