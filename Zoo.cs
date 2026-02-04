using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Zoo
    {
        public List<Animal> Animals = new List<Animal>();
        public void CreateAnimal (string name, Type type, int age) {
            Animal NewAnimal = new Animal(name, type, age);
            Animals.Add(NewAnimal);
            Console.WriteLine("добавленно животное: " + name);
        }

        public void DestroyAnimal(string name)
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].name == name)
                {
                    Animals.Remove(Animals[i]);
                }
            }
            Console.WriteLine("удаленно животное: " + name);
        }

        public void ShowAllAnimals()
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.WriteLine("Название животного: " + Animals[i].name + " Тип животного: " + Animals[i].type.ToString() + " возраст животного: " + Animals[i].Age.ToString());
                //Console.WriteLine(Animals[i]);
            }
        }

    }
}
