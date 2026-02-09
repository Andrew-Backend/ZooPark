using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Aplication
{
    public class ManagementService : IManagementService
    {
        private readonly Zoo zoo;
        private bool IsOpen;

        public ManagementService(Zoo zoo)
        {
            this.zoo = zoo;
        }

        public void OpenZoo()
        {
            IsOpen = true;
        }

        public void CloseZoo() 
        {
            IsOpen = false;
        }

        public bool IsZooOpen()
        {
            return IsOpen;
        }

        public void AddAnimal(string name, TypeOfAnimal type, int age)
        {
            Animal animal = new Animal(name, type, age);
            if (!IsOpen)
            {
                Console.WriteLine("Зоопарк закрыт!");
            }else{
                zoo.AddAnimal(animal);
            }
        }

        public void RemoveAnimal (string name)
        {
            if (!IsOpen)
            {
                Console.WriteLine("Зоопарк закрыт!");
            }
            else
            {
                zoo.DestroyAnimal(name);
            }
        }

        public int GetAnimalCount ()
        {
            return zoo.Animals.Count;
        }

        public void ShowAnimals ()
        {
            zoo.ShowAllAnimals();
        }

        public void DisplayMenu ()
        {
            Console.WriteLine(
                "Menu:\n" +
                "0. Выход\n" +
                "1. Открыть зоопарк\n" +
                "2. Закрыть зоопарк\n" +
                "3. Открыт ли зоопарк?\n" +
                "4. Добавить животное\n" +
                "5. Убрать животное\n" +
                "6. Количество животных\n" +
                "7. Показать всех животных\n" +
                "8. Показать меню\n");
        }

        public void Menu ()
        {
            DisplayMenu();
            while (true)
            {
                int choise;
                string name = "";
                int age = 0;
                int number = 0;


                if (!int.TryParse(Console.ReadLine(), out choise))
                {
                    Console.WriteLine("Неверный ввод!");
                    continue;
                }
                
                switch (choise)
                {
                    case 0:
                        return;
                    case 1:
                        OpenZoo(); 
                        break;
                    case 2:
                        CloseZoo();
                        break;
                    case 3:
                        if (IsOpen)
                        {
                            Console.WriteLine("Зоопарк открыт");
                        }
                        else
                        {
                            Console.WriteLine("Зоопарк закрыт");
                        }
                        break;
                    case 4:
                        do{
                            Console.WriteLine("Введите Имя животного:");
                            name = Console.ReadLine();
                        } while (String.IsNullOrEmpty(name));

                        
                        while (true)
                        {
                            Console.WriteLine("Введите возраст животного:");
                            if (int.TryParse(Console.ReadLine(), out age))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" Ожидается целое число");
                            }
                        }

                        Console.WriteLine("Выберите номер типа животного из списка: " +
                            "1. млекопитающее\n" +
                            "2. птица\n" +
                            "3. земноводное\n" +
                            "4. рептилия\n");

                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" Неверный ввод, попробуйте еще раз");
                            }
                        }

                        AddAnimal(name, (TypeOfAnimal)number, age);
                        break;
                    case 5:
                        Console.WriteLine("Введите имя животного для удаления:");

                        do
                        {
                            Console.WriteLine("Введите Имя животного:");
                            name = Console.ReadLine();
                        } while (String.IsNullOrEmpty(name));
                        RemoveAnimal(name);
                        break;
                    case 6:
                        int count = GetAnimalCount();
                        Console.WriteLine("Количество животных: " + count);
                        break;
                    case 7:
                        ShowAnimals();
                        break;
                    case 8:
                        DisplayMenu(); 
                        break;
                    default:
                        Console.WriteLine(" Неверный ввод!");
                        break;

                }
            }
        }
    }
}
