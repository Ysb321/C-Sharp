using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample
{
    public class Manager
    {
        public void ManagerName() 
        {
            Console.WriteLine("Yash");
        }

    }

    public class Manager // we can not create another class without partial keyword
    {
        public void ManagerName()
        {
            Console.WriteLine("Yash");
        }

    }
}
