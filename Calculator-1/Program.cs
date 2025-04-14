using System.IO.Pipelines;
using System.Text.RegularExpressions;

Console.WriteLine("Welcome to calculator.");

while (true)
{
    string input = "";
    Console.WriteLine("");

    Console.Write("Number 1: ");
    input = Console.ReadLine().Trim();


    if (!string.IsNullOrEmpty(input))
    {
        if (input == "exit") break;
        double number1 = Convert.ToInt32(input.Trim());

        Console.Write("Operation: ");
        input = Console.ReadLine().Trim();

        if (!string.IsNullOrEmpty(input))
        {
            if (input == "exit") break;
            string operators = input;

            Console.Write("Number 2: ");
            input = Console.ReadLine().Trim();

            if (!string.IsNullOrEmpty(input))
            {
                if (input == "exit") break;
                double number2 = Convert.ToInt32(input);

                double result = 0;

                switch (operators)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }
        }
    }


}

