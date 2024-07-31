using Lab1___2__PA;

List <Products> ProductList = new List<Products>();



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
    int option = int.Parse(Console.ReadLine());
    return option;
}
