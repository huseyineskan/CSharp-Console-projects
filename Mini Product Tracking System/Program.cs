Console.WriteLine("Mini Product Tracking System");
int menuNumber;
// We keep the main menu and submenus in a List.
var menu = new List<(string MainMenu, List<string> SubMenus)>
{
    ("Product Management", new List<string> {"Add product", "List product", "Update product", "Delete product"}),
    ("Category Management", new List<string> {"Add category", "List category", "Update category", "Delete category"})
};
Console.WriteLine();

Console.WriteLine("--------- MENU ---------");
menuNumber = 1;
foreach (var (mainMenu, subMenu) in menu)
{
    Console.WriteLine($"{menuNumber}.{mainMenu}");
    menuNumber++;
}

while (true)
{
    Console.Write("\nMenu number: ");
    bool input = int.TryParse(Console.ReadLine(), out menuNumber);

    if (input)
    {
        Console.WriteLine(menuNumber);
        break;
    }
    else
    {
        Console.WriteLine("Invalid.");
    }
}

Console.ReadLine();