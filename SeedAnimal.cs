using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal static class SeedAnimal
    {
        static public Zoo SeedData()
        {
            Zoo ZooPark = new Zoo();

            ZooPark.AddAnimal("тигр", Type.млекопитающее, 6);
            ZooPark.AddAnimal("крокодил", Type.рептилия, 10);
            ZooPark.AddAnimal("гусь", Type.птица, 4);
            ZooPark.AddAnimal("лягушка", Type.земноводное, 1);
            ZooPark.AddAnimal("фазан", Type.птица, 2);
            ZooPark.AddAnimal("утка", Type.птица, 3);

            return ZooPark;
        }
    }
}
