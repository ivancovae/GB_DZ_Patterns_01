using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    public class Human
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public Human(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }
    }
}
