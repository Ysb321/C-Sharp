using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionOverriding
{
    public class Base
    {
        public virtual string Name() // overriding possible without using virtual and override keyword
        {
            return "Yash";
        }
    }
}
