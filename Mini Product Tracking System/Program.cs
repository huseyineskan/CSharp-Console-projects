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

bool condition = true;
List<Product> productList = new List<Product>();

// TEST PRODUCT
productList.Add(new Product { ProductName = "Notebook", ProducId = 1, });
productList.Add(new Product { ProductName = "Mobile Phone", ProducId = 2, });
productList.Add(new Product { ProductName = "Printer", ProducId = 3, });

while (condition)
{
    Console.WriteLine();
    Console.WriteLine("--------- MENU ---------");
    int listNumber = 1;
    foreach (var mainMenu in menuList)
    {
        Console.WriteLine($"{listNumber}.{mainMenu.Title}");
        listNumber++;
    }
    Console.WriteLine("0.Exit");

    Console.Write("\nMenu number: ");
    string inputStr = Console.ReadLine().Trim();
    if (inputStr == "exit") break;
    Console.WriteLine();
    bool input = int.TryParse(inputStr, out menuNumber);

    if (input)
    {
        switch (menuNumber)
        {
            case 0:
                condition = false;
                break;
            case 1:
                Console.WriteLine("--------- Sales Transactions ---------");
                break;
            case 2:
                Console.WriteLine("--------- Product Management ---------");

                foreach (MenuItem menu in menuList)
                {
                    if (menu.Title == "Product Management")
                    {
                        for (int i = 0; i < menu.SubMenus.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{menu.SubMenus[i].Title}");
                        }
                        Console.WriteLine("0.Back");
                        Console.Write("\nSelect a Sub Menu: ");
                        bool isNumber = int.TryParse(Console.ReadLine().Trim(), out menuNumber);
                        Console.WriteLine();
                        do
                        {
                            switch (menuNumber)
                            {
                                case 0:
                                    break;
                                case 1:
                                    ProductAdd();
                                    break;
                                case 2:
                                    ListAllProducts();
                                    break;
                                case 3:
                                    Console.WriteLine("Ürün güncelleniyor...");
                                    break;
                                case 4:
                                    Console.WriteLine("Ürün siliniyor...");
                                    break;
                            }
                        } while (!isNumber);
                    }
                }
                break;
            case 3:
                Console.WriteLine("--------- Category Management ---------");
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

void ProductAdd()
{
    Console.WriteLine("You are adding a product:");
    Console.Write("Product Name: ");
    string productName = Console.ReadLine();

    Console.Write("Category: ");
    string productCategory = Console.ReadLine();

    Product newProduct = new Product();
    newProduct.ProductName = productName;
    newProduct.CategoryId = int.Parse(productCategory);

    productList.Add(newProduct);
}

void ListAllProducts()
{
    Console.WriteLine("You are listing products:");
    for (int i = 0; i < productList.Count; i++)
    {
        Console.WriteLine($"{i + 1}.{productList[i].ProductName} - ({productList[i].ProducId})");
    }
    Console.WriteLine();
    Console.Write("<-Back");
    Console.Read();
}

class MenuItem
{
    public string Title { get; set; }
    public List<MenuItem> SubMenus { get; set; } = new List<MenuItem>();
}

class Product
{
    public int ProducId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}