Console.WriteLine("Mini Product Tracking System");

int menuNumber;
// We keep the main menu and submenus in a List.
// var menu = new List<(string MainMenu, List<string> SubMenus)>
// {
//     ("Product Management", new List<string> {"Add product", "List product", "Update product", "Delete product"}),
//     ("Category Management", new List<string> {"Add category", "List category", "Update category", "Delete category"})
// };

var menuList = new List<MenuItem>{
    new MenuItem{
        Title = "Sales Transactions"
    },
    new MenuItem{
        Title = "Product Management",
        SubMenus = {
            new MenuItem{Title = "Add product"},
            new MenuItem{Title = "List product"},
            new MenuItem{Title = "Update product"},
            new MenuItem{Title = "Delete product"},
        }
    },
    new MenuItem{
        Title= "Category Management",
        SubMenus = {
            new MenuItem { Title = "Add category"},
            new MenuItem { Title = "List category"},
            new MenuItem { Title = "Update category"},
            new MenuItem { Title = "Delete category"},
        }
    }
};

Console.WriteLine();

Console.WriteLine("--------- MENU ---------");

int listNumber = 1;

foreach (var mainMenu in menuList)
{
    Console.WriteLine($"{listNumber}.{mainMenu.Title}");
    listNumber++;
}
Console.WriteLine("0.Exit");
bool condition = true;
while (condition)
{
    Console.Write("\nMenu number: ");
    string inputStr = Console.ReadLine().Trim();
    if (inputStr == "exit") break;

    bool input = int.TryParse(inputStr, out menuNumber);

    if (input)
    {
        switch (menuNumber)
        {
            case 0:
                condition = false;
                break;
            case 1:
                Console.WriteLine("Sales Transactions");
                break;
            case 2:
                Console.WriteLine("Product Management");
                break;
            case 3:
                Console.WriteLine("Category Management");
                break;
            default:
                Console.WriteLine("Invalid.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid.");
    }
}

class MenuItem
{
    public string Title { get; set; }
    public List<MenuItem> SubMenus { get; set; } = new List<MenuItem>();
}