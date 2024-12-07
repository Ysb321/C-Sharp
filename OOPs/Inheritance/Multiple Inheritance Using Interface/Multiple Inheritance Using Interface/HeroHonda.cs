using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance_Using_Interface
{
    public class HeroHonda:Hero,Honda
    {
        public string PartDetails() // Implimantation of function
        {
            return "Outer Design";
        }
        public DateTime ManufactureDate() // This function will override bcoz it declare at both classes
        {
            return DateTime.Today;
        }

        public string EnginDetails()
        {
            return "750hp";
        }

    }
}
