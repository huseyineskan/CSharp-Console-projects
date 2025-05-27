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
productList.Add(new Product { ProductName = "Notebook", ProducId = 1, ProductCategoryId = 1 });
productList.Add(new Product { ProductName = "Mobile Phone", ProducId = 2, ProductCategoryId = 2 });
productList.Add(new Product { ProductName = "Printer", ProducId = 3, ProductCategoryId = 21 });

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
                                    UpdateProduct();
                                    break;
                                case 4:
                                    DeleteProduct();
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
    bool isNumber;
    string productName;
    int productCategory = 33;

    Console.WriteLine("You are adding a product:");

    do
    {
        Console.Write("Product Name: ");
        productName = Console.ReadLine();
    } while (string.IsNullOrEmpty(productName));
    do
    {
        Console.Write("Category: ");
        isNumber = int.TryParse(Console.ReadLine(), out productCategory);
    } while (!isNumber);


    Product newProduct = new Product
    {
        ProductName = productName,
        ProductCategoryId = productCategory,
    };

    productList.Add(newProduct);
}

void DeleteProduct()
{
    Console.WriteLine("You are deleting product:");
}

void UpdateProduct()
{
    Console.WriteLine("You are updating product:");
}

void ListAllProducts()
{
    Console.WriteLine("You are listing products:\n");
    Console.WriteLine("ID  CTG\tPRODUCT NAME");
    for (int i = 0; i < productList.Count; i++)
    {
        Console.WriteLine($"{i + 1}.  {productList[i].ProductCategoryId}\t{productList[i].ProductName}");
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
    public int ProductCategoryId { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}