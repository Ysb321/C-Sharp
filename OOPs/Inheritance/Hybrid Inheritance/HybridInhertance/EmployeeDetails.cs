using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridInhertance
{
    public class EmployeeDetails:Derived1,Derived2 // Final Derived Class, for fixing dimond problem we have to add interface all above classes
    {
        public int EmpNumber()
        {
            return 100;
        }
        public float EmpSalary()
        {
            return 23333333.3f;
        }

        public string Address()
        {
            return "Pune";
        }

        public int Age()
        {
            return 23;
        }
        public string Name()
        {
           return "Yashraj";
        }

    }
}
