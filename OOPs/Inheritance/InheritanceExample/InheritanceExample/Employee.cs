using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee : AuditEntity
    {

        public string EmpName { get; set; } // It is property
        public int EmpId { get; set; }

        public void GetMassage()
        {
            Console.WriteLine("Deriverd Class");
        }
    }
}
