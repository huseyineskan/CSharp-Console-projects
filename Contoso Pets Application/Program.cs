namespace Contoso_Pets_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Pets App\n");
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Please select a selection:\n1.Add a new pet");
                string menu = Console.ReadLine();
                Console.WriteLine("menu");
                Console.WriteLine();

                switch (menu)
                {
                    case "exit":
                        condition = false;
                        break;
                    case "1":
                        Console.WriteLine("You selected 1");
                        Console.WriteLine(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}