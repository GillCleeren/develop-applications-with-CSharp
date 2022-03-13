namespace CarvedRock.Backend
{
    public class Bag : Product
    {
        public string Capacity { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Bag(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus, string productCode, string capacity, double weight, string color) : base(id, name, description, basePrice, amountInStock, productStatus, productCode)
        {
            Capacity = capacity;
            Weight = weight;
            Color = color;
        }

        public override string DisplayProduct()
        {
            return $"BAG\n" +
                   $"---\n" +
                   $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nSale Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", SalePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus}\nProduct Code: {ProductCode}\n";

        }
    }
}
