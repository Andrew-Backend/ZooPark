using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public enum Type
    {
        млекопитающее,
        птица,
        земноводное,
        рептилия
    }
    internal class Animal
    {
        public string name;
        public Type type;
        private int age;

        public int Age { 
            get { return age; }
            set {
                if (value >= 0)
                {
                    age = value;
                } else {
                    Console.WriteLine("Возраст не может быть отрицательным");
                }
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public Animal(string name, Type type, int age)
        {
            this.name = name;
            this.type = type;
            Age = age;
        }
    }
}
