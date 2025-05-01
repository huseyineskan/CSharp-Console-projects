namespace Contoso_Pets_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] menuTexts = {
                "1. Add a new pet.",
                "2. List of all pets.",
                "3. Edit pet information.",
                "4. Delete pet.",
                "Exit"
            };

            List<Pets> ourAnimals = new List<Pets>{
                new Pets{
                    petId= 1,
                    petSpecies = "dog",
                    petNickname = "Buddy",
                    petAge = 2,
                    petPhysicalConditionDescription = "medium sized cream colored",
                    petPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail.",
                    // petAdoptionSituation = true,
                    // petMedicalHistory = "there isn't information",
                },
                new Pets{
                    petId= 2,
                    petSpecies = "cat",
                    petNickname = "Pussi",
                    petAge = 4,
                    petPhysicalConditionDescription = "little boy",
                    petPersonalityDescription = "gives lots of kisses.",
                    // petAdoptionSituation = false,
                    // petMedicalHistory = "Her right hind leg was broken in 2020",

                }
            };
            Console.WriteLine($"Welcome to Contoso Pets Application.");
            bool condition = true;
            while (condition)
            {
                string? menu;
                Console.WriteLine("\n-------------- MAIN MENU --------------");
                foreach (var item in menuTexts)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                do
                {
                    Console.Write("Select a menu: ");
                    menu = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(menu));
                Console.WriteLine();

                switch (menu.ToLower())
                {
                    case "exit":
                        condition = false;
                        break;
                    case "1":
                        string? petSpeciesInput, petNicknameInput, petPhysicalConditionDescriptionInput, petPersonalityDescriptionInput, petAgeInput;
                        int petAgeNumber;

                        do
                        {
                            Console.Write("Pet Species (cat, dog etc.): ");
                            petSpeciesInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(petSpeciesInput));

                        do
                        {
                            Console.Write("Pet Nickname: ");
                            petNicknameInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(petNicknameInput));

                        do
                        {
                            Console.Write("Pet Age: ");
                            petAgeInput = Console.ReadLine();
                            petAgeNumber = int.Parse(petAgeInput);
                        } while (string.IsNullOrWhiteSpace(petAgeInput));

                        do
                        {
                            Console.Write("Pet Physical Condition Description: ");
                            petPhysicalConditionDescriptionInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(petPhysicalConditionDescriptionInput));

                        do
                        {
                            Console.Write("Pet Personality Description: ");
                            petPersonalityDescriptionInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(petPersonalityDescriptionInput));

                        int newPetId = (ourAnimals.Count > 0) ? ourAnimals[ourAnimals.Count - 1].petId + 1 : 1;

                        ourAnimals.Add(new Pets
                        {
                            petId = newPetId,
                            petSpecies = petSpeciesInput,
                            petNickname = petNicknameInput,
                            petAge = petAgeNumber,
                            petPhysicalConditionDescription = petPhysicalConditionDescriptionInput,
                            petPersonalityDescription = petPersonalityDescriptionInput
                        });

                        Console.WriteLine();
                        string petAddMessage = "- Could not add pet. Please try again.";

                        for (int i = 0; i < ourAnimals.Count; i++)
                        {
                            if (ourAnimals[i].petId == newPetId)
                            {
                                petAddMessage = ($"+ Pet '{petNicknameInput}' added successfully.");
                            }
                        }
                        Console.WriteLine(petAddMessage);
                        break;
                    case "2":
                        ReturnAllAnimals();
                        string petDetailInput;
                        bool petDetailIsNumber;
                        do
                        {
                            Console.Write("Pet details (ID): ");
                            petDetailInput = Console.ReadLine();
                            petDetailIsNumber = isNumberMethod(petDetailInput);

                        } while (!petDetailIsNumber);

                        Console.WriteLine("\n**************** PET DETAILS ****************\n");
                        bool isTherePet = false;
                        foreach (var pet in ourAnimals)
                        {
                            if (pet.petId == Convert.ToInt32(petDetailInput))
                            {
                                Console.WriteLine($"Pet ID: {pet.petId}\nPet Species: {pet.petSpecies}\nPet Nickname: {pet.petNickname}\nPet Physical Condition Description: {pet.petPhysicalConditionDescription}\nPet Personality Description: {pet.petPersonalityDescription}");
                                isTherePet = true;
                                // \nPet Adoption: {pet.petAdoptionSituation}\nPet Medical History: {pet.petMedicalHistory}
                            }
                        }
                        if (!isTherePet) Console.WriteLine("No pet found!");
                        Console.WriteLine("\n**********************************************");
                        Console.Write("<- Back");
                        Console.Read();
                        break;
                    case "3":
                        ReturnAllAnimals();
                        string updateIdInput;
                        bool isNumber;
                        do
                        {
                            Console.Write("Which pet (ID) do you want to update?: ");
                            updateIdInput = Console.ReadLine();
                            isNumber = isNumberMethod(updateIdInput);

                        } while (!isNumber);

                        var petToEdit = ourAnimals.FirstOrDefault(p => p.petId == Convert.ToInt32(updateIdInput));

                        if (petToEdit != null)
                        {
                            Console.Write($"Pet Species ({petToEdit.petSpecies}): ");
                            string newPetSpecies = Console.ReadLine();

                            Console.Write($"Pet Nickname({petToEdit.petNickname}): ");
                            string newPetName = Console.ReadLine();

                            Console.Write($"Pet Age({petToEdit.petAge}): ");
                            string newPetAge = Console.ReadLine();
                            bool isNumberAge = isNumberMethod(newPetAge);

                            Console.Write($"Pet Physical Condition Description({petToEdit.petPhysicalConditionDescription}): ");
                            string newPetPhysicalCondition = Console.ReadLine();

                            Console.Write($"Pet Personality Description({petToEdit.petPersonalityDescription}): ");
                            string newPetPersonalityDescription = Console.ReadLine();


                            if (!string.IsNullOrEmpty(newPetSpecies) || !string.IsNullOrEmpty(newPetName) || !string.IsNullOrEmpty(newPetAge) || !string.IsNullOrEmpty(newPetPhysicalCondition) || !string.IsNullOrEmpty(newPetPersonalityDescription))
                            {
                                petToEdit.petSpecies = newPetSpecies;
                                petToEdit.petNickname = newPetName;
                                petToEdit.petPhysicalConditionDescription = newPetPhysicalCondition;
                                petToEdit.petPersonalityDescription = newPetPersonalityDescription;

                                if (isNumberAge)
                                {
                                    petToEdit.petAge = Convert.ToInt32(newPetAge);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Boş bıraktı");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No pet found!");
                        }
                        Console.WriteLine(Console.ReadLine());
                        break;
                    case "4":
                        ReturnAllAnimals();
                        string deleteIdInput;
                        bool result;

                        do
                        {
                            int i = 0;
                            Console.Write("Which pet (ID) do you want to delete? (0:exit): ");
                            deleteIdInput = Console.ReadLine();
                            result = int.TryParse(deleteIdInput, out i);
                        } while (!result);

                        int isDeteled = ourAnimals.RemoveAll(p => p.petId == Convert.ToInt32(deleteIdInput));

                        if (isDeteled != 0)
                        {
                            Console.WriteLine($"The pet {deleteIdInput} was deleted.");
                        }
                        else if (deleteIdInput != "0")
                        {
                            Console.WriteLine($"The pet {deleteIdInput} wasn't deleted.");
                        }
                        break;
                    default:
                        break;
                }
            }

            void ReturnAllAnimals()
            {
                Console.WriteLine($"#ID\tTYPE\tAGE\tNICKNAME\tPHYSICAL CONDITION");

                for (int i = 0; i < ourAnimals.Count; i++)
                {
                    Console.WriteLine($"{ourAnimals[i].petId}\t{ourAnimals[i].petSpecies}\t{ourAnimals[i].petAge}\t{ourAnimals[i].petNickname}\t\t{ourAnimals[i].petPhysicalConditionDescription}");
                }
                Console.WriteLine();
            }

            bool isNumberMethod(string input)
            {
                int i = 0;
                bool isNumber = int.TryParse(input, out i);
                return isNumber;
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
        // public bool petAdoptionSituation { get; set; }
        // public string petMedicalHistory { get; set; }

    }

}