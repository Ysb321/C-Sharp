using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singel_Inheritance
{
    public class Audit
    {
        public Audit()
        {
            Console.WriteLine("This is Base Class Constructor.");
        }
        public DateTime CreatedON {  get; set; }
        public  string CreatedBY { get; set; }

        public DateTime ModifiedON { get; set; }
        public string ModifiedBY { get; set; }
    }
}
