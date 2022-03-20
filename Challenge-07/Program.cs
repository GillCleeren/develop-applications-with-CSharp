


using CarvedRock.Backend;

List<Product> products = Utilities.ReadInventoryFile("inventory.txt");
foreach (var product in products)
{
    Console.WriteLine(product.DisplayProduct());
}


