using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Company // we have to implement every abstract data member or function
    {
        public override string CompanyName()
        {
            return "TCS";
        }
        public override string CompanyDesc()
        {
            return "Software Company";
        }
    }
}
