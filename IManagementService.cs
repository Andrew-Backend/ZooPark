using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal interface IManagementService
    {
        void OpenZoo();

        void CloseZoo();

        void AddAnimal(string name,Type type, int age);

        void RemoveAnimal(string name);

        int GetAnimalCount();

        void ShowAnimals();
    }
}
