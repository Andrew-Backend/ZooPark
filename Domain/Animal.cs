using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Domain
{
    public class Animal
    {
        private string name;
        public string Name { get { return name; } }

        private TypeOfAnimal type;
        public TypeOfAnimal Type { get { return type; } }

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

        public Animal(string name, TypeOfAnimal type, int age)
        {
            this.name = name;
            this.type = type;
            Age = age;
        }
    }
}
