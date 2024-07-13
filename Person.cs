using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C42_G02_OOP01
{
    internal struct Person
    {
        private string name;
        private int age;
        

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            set
            {
                if(value.Length > 0 && value.Length < 100)
                    name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                if (value > 0 && value < 150)
                    age = value;
            }
            get
            {
                return age;
            }
        }

        public override string ToString()
        {
            return $"the oldest person's name: {name}, and age: {age}";
        }
    }
}
