


using CarvedRock.Backend;

List<Product> products = Utilities.ReadInventoryFile("inventory.txt");

var cyclingFootwearInStock = Utilities.GetFilteredCyclingFootwear(products);

foreach (var product in cyclingFootwearInStock)
{
    Console.WriteLine(product.DisplayProduct());
}

Utilities.ExportToJson(cyclingFootwearInStock);