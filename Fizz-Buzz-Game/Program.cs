Console.WriteLine("Welcome to Fizz Buzz Game");

while (true)
{
    Console.Write("How long do you want the game to continue?: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int maxNumber))
    {
        int fizz = 0;
        int buzz = 0;
        int fizzbuzz = 0;

        for (int i = 1; i <= maxNumber; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                Console.WriteLine($"{i}.Fizz Buzz");
                fizz++;
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i}.Fizz");
                buzz++;
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i}.Buzz");
                fizzbuzz++;
            }
            else
            {
                Console.WriteLine(i + ".");
            }
        }
        Console.WriteLine($"\nFinal Report\nFizz: {fizz}\nBuzz: {buzz}\nFizzBuzz: {fizzbuzz}\n");
    }
    else
    {
        if (input == "exit") break;
        Console.WriteLine("Please enter a number!");
    }
}
