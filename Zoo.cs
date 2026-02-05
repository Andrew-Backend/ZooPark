using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooPark
{
    internal class Zoo
    {
        public List<Animal> Animals = new List<Animal>();
        public void AddAnimal (string name, Type type, int age) 
        {
            Animal NewAnimal = new Animal(name, type, age);
            Animals.Add(NewAnimal);
            Console.WriteLine("добавленно животное: " + name);
        }

        public void AddAnimal (Animal NewAnimal)
        {
            Animals.Add(NewAnimal);
            Console.WriteLine("добавленно животное: " + NewAnimal.Name);
        }

        public void DestroyAnimal(string name)
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Name == name)
                {
                    Animals.Remove(Animals[i]);
                    Console.WriteLine("Удаленно животное: " + name);
                    return;
                }
            }
            Console.WriteLine("Такого животного нет");
        }

        public void ShowAllAnimals()
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.WriteLine("Название животного: " + Animals[i].Name + ". Тип животного: " + Animals[i].Type.ToString() + ", возраст животного: " + Animals[i].Age.ToString());
                //Console.WriteLine(Animals[i]);
            }
        }

        public void SearchAnimal (string name)
        {
            Console.WriteLine("Поиск животного: " + name);
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Name == name)
                {
                    Console.WriteLine("Животное есть в зоопарке.");
                    return;
                }
            }
            Console.WriteLine("Такого животного нет.");
        }


    }
}
