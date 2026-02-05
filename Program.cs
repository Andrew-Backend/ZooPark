namespace ZooPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo ZooPark = SeedAnimal.SeedData();

            ManagementService ServiceZoo = new ManagementService(ZooPark);

            ServiceZoo.Menu();

        }
    }
}
