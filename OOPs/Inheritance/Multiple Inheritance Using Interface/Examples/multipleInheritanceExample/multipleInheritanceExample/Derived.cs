using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInheritanceExample
{
    public class Derived : Ibase, Ibase2
    {
        public string Name()
        {
            return "Yashraj";
        }

        public string Surname()
        {
            return "Boralkar";
        }
        public float salary()
        {
            return 2.2F;
        }
        public int age()
        {
            return 24;
        }

    }
}
