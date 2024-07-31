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
static bool GoOut(ref bool generalContinue)
{
    Console.WriteLine("You are Leaving the Program");
    generalContinue = false;
    return generalContinue;
}
static void SwitchOption(ref List<Products> productList, ref int idPosition, ref int QuantityID, ref bool generalContinue)
{
    idPosition = 0;
    switch (ShowMenu())
    {
        case 1:
            Products.AddProduct(ref QuantityID, ref productList);
            break;
        
        case 2:
            Products.ConsultInformation(ref idPosition, ref productList);
            break;

        case 3:
            Products.SellProducts(ref idPosition, ref productList);
            break;

        case 4:
            Products.FillStock(ref idPosition, ref productList);
            break;

        case 5:
            Products.UpdatePrice(ref idPosition, ref productList);
            break;

        case 6:
            GoOut(ref generalContinue);
            break;

        default:
            Console.WriteLine("Please Enter a Valid Option (1 - 6)");
            Console.ReadKey();
            break;
    }
}