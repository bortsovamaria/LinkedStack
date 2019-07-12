using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    class Dog
    {
        string name;
        public Dog(string name)
        {
            this.name = name;
        }

        public string Voice()
        {
            return "Gav " + name;
        }
    }
}
