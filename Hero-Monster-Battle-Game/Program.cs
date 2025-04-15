Random random = new Random();
int attackValue = 0;
int healthPoint = 10;
string result = "";
string heroName = "Hero";
string monsterName = "Monster";

while (true)
{
    Console.Write("Your name: ");
    string heroInput = Console.ReadLine().Trim();
    if (heroInput.Length != 0) heroName = heroInput;
    break;
}

while (true)
{
    Console.Write("Monster name: ");
    string monsterInput = Console.ReadLine().Trim();
    if (monsterInput.Length != 0)
    {
        if (monsterInput.ToLower() == heroName.ToLower())
        {
            Console.WriteLine("Hero and Monster cannot have the same name. Try again!");
        }
        monsterName = monsterInput;
    }
    break;
}

while (true)
{
    Console.Write("Health points: ");
    string healthInput = Console.ReadLine().Trim();
    if (healthInput.Length != 0)
    {
        if (int.TryParse(healthInput, out int output)) healthPoint = output;
    }
    break;
}

int heroHealth = healthPoint;
int monsterHealth = healthPoint;

int counter = 2;
Console.WriteLine("");

while (heroHealth > 0 && monsterHealth > 0)
{
    attackValue = random.Next(1, 11);

    if (counter % 2 == 0)
    {
        // Hero is attacking.
        monsterHealth -= attackValue;
        Console.WriteLine($"{monsterName} was damaged and lost {attackValue} health and now has {monsterHealth} health.");
        counter++;
    }
    else
    {
        // Monster is attacking.
        heroHealth -= attackValue;
        Console.WriteLine($"{heroName} was damaged and lost {attackValue} health and now has {heroHealth} health.");
        counter++;
    }

    result = heroHealth <= 0 ? monsterName : heroName;

}

Console.WriteLine($"{result} wins!");
Console.WriteLine("");