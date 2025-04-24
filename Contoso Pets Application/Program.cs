namespace Contoso_Pets_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] menuTexts = {
                "List all of our current pet information.",
                "Assign values to the ourAnimals array fields.",
                "Ensure animal ages and physical descriptions are complete.",
                "Ensure animal nicknames and personality descriptions are complete.",
                "Edit an animal’s age.",
                "Edit an animal’s personality description.",
                "Display all cats with a specified characteristic.",
                "Display all dogs with a specified characteristic.",
            };

            List<Pets> ourAnimals = new List<Pets>{
                new Pets{
                    petId= 1,
                    petSpecies = "dog",
                    petNickname = "Buddy",
                    petAge = 2,
                    petPhysicalConditionDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
                    petPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses."
                },
                new Pets{
                    petId= 2,
                    petSpecies = "cat",
                    petNickname = "Pussi",
                    petAge = 4,
                    petPhysicalConditionDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
                    petPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses."
                }
            };
            Console.WriteLine($"Welcome to Contoso Pets Application.\n");

            Console.WriteLine("-------------- MAIN MENU --------------");
            for (int i = 0; i < menuTexts.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuTexts[i]}");
            }
            Console.WriteLine("");
            Console.Write("Select a menu: ");
            string menu = Console.ReadLine();

            switch (menu.ToLower())
            {
                case "exit":
                    break;
                case "1":
                    Console.WriteLine("1. List all of our current pet information.\n");
                    Console.WriteLine($"#ID\tTYPE\tAGE\tNICKNAME");

                    for (int i = 0; i < ourAnimals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}\t{ourAnimals[i].petSpecies}\t{ourAnimals[i].petAge}\t{ourAnimals[i].petNickname}");
                    }
                    Console.WriteLine("");
                    Console.Write("<- Back ");
                    Console.Read();
                    break;
                case "2":
                    Console.WriteLine("You selected 2.List of available pets.");
                    Console.WriteLine(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }
    }

    class Pets
    {
        public int petId { get; set; }
        public string petSpecies { get; set; }
        public string petNickname { get; set; }
        public int petAge { get; set; }
        public string petPhysicalConditionDescription { get; set; }
        public string petPersonalityDescription { get; set; }
    }

}