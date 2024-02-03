using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Abstract
{
    // Faculty class
    public class Faculty : Person
    {
        public string Role { get; set; }

        public Faculty(string name, int id, string role) : base(name, id)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, Role: {Role}";
        }
    }
}
