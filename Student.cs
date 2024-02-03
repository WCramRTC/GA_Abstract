using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Abstract
{
    // Student class
    public class Student : Person
    {
        public double GPA { get; set; }

        public Student(string name, int id, double gpa) : base(name, id)
        {
            GPA = gpa;
        }

        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, GPA: {GPA}";
        }
    }
}
