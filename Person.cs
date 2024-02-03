using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Abstract
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        // Constructor to initialize common properties.
        protected Person(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // 2. Abstract method to be implemented by derived classes to return details about the person.
        public abstract string GetDetails();
    }
}
