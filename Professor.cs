using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Abstract
{
    // Professor class
    public class Professor : Person
    {
        public string Department { get; set; }

        public Professor(string name, int id, string department) : base(name, id)
        {
            Department = department;
        }

        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, Department: {Department}";
        }
    }
}
