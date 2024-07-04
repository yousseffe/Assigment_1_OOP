using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1_OOP
{
    internal struct Person1
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person1(String _name, int _age)
        {
            name = _name;
            age = _age;
        }
    }
}
