using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance_Using_Interface
{
    public interface Hero
    {
        string PartDetails();  // Declaration of function
        DateTime ManufactureDate();
    }
}
