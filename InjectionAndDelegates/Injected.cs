using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionAndDelegates
{
    public class Injected
    {
        public string Name { get; private set; }
        public Injected(string name)
        {
            Name = name;
        }

        public string YourNameAndDouble(int number)
        {
            return $"{Name}: {number * 2}";
        }

    }
}
