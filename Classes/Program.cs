namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою");
            string name = Console.ReadLine();
            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            int.TryParse(Console.ReadLine(), out int health); 


            
        }
    }
}
