using Lab1___2__PA;

int QuantityID = 1; int idPosition = 0;
bool generalContinue = true;
List <Products> productList = new List<Products>();

while (generalContinue)
{
    try
    {

    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR!, Incorrect Data");
        Console.ReadKey();
    }
}

static int ShowMenu()
{
    Console.Clear();
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. Consult Information");
    Console.WriteLine("3. Sell Products");
    Console.WriteLine("4. Fill Stock");
    Console.WriteLine("5. Update Price");
    Console.WriteLine("6. Go Out");
    Console.WriteLine("\nChoose a Option");
    int optionMenu = int.Parse(Console.ReadLine());
    return optionMenu;
}

static void SwitchOption()
{
    idPosition = 0;
    switch (ShowMenu())
    {
        case 1:
            break;
        
        case 2:
            break;

        case 3:
            break;

        case 4:
            break;

        case 5:
            break;

        case 6:
            break;

        default:
            break;
    }
}
