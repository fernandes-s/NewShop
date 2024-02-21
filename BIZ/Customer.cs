using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Customer : Person
    {     
        public Customer(string fn, string sn, string dob, string ge, string cy) :base(fn, sn, dob, ge, cy)
        {
            AddStuff ast = new AddStuff();
            ast.AddCus(fn, sn, dob, ge, cy);
        }

        

    }
}
