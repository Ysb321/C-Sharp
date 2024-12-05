using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample
{
    public partial class data // multiple class haing one object where class name is same
    {
        public string GetEmployee()
        {
            return "Yash";
        }
    }
    public partial class data
    {
        public int GetSalary()
        {
            return 2000000;
        }
    }
}
