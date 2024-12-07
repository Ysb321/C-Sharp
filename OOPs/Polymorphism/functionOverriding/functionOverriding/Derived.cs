using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionOverriding
{
    public class Derived: Base
    {
        public override string Name() // don't need override keyword to overriding function
        {
            return "yashraj";
        }
    }
}
