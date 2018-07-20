using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    class DefaultDummy : IDummy
    {
        public static readonly string Address = Constants.Address;
        public static readonly string Format = Constants.Format;

        protected void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }

        public virtual object DummyFunc(Human human)
        {
            WriteToConsole(human.Name, human.Description, human.Age);
            return null;
        }
    }
}
