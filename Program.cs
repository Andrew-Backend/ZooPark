namespace ZooPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo ZooPark = new Zoo();
            ZooPark.CreateAnimal("тигр", Type.млекопитающее, 6);
            ZooPark.CreateAnimal("крокодил", Type.рептилия, 10);
            ZooPark.CreateAnimal("гусь", Type.птица, 4);
            ZooPark.CreateAnimal("лягушка", Type.земноводное, 1);

            ZooPark.ShowAllAnimals();

            ZooPark.DestroyAnimal("гусь");

            ZooPark.ShowAllAnimals();


        }
    }
}
