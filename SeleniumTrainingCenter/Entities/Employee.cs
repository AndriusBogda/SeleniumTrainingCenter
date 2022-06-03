using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrainingCenter.Entities
{
    public class Employee : Person
    {
        public string Postion { get; set; }
        public string Office { get; set; }

        public Employee(string name, string postion, string office) : base(name)
        {
            Postion = postion;
            Office = office;
        }
    }
}
