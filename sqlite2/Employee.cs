using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612
{
    // POCO -- plain old clr object
    public class Employee
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public double SALARY { get; set; }
        public int AGE { get; set; }

        public override string ToString()
        {
            return $"{ID} {NAME} {ADDRESS} {SALARY} {AGE}";
        }
    }
}
