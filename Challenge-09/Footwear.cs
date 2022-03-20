namespace CarvedRock.Backend
{
    public class Footwear : Product
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public bool Waterproof { get; set; }

        public Footwear(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus, string productCode, string color, string material, bool waterproof) : base(id, name, description, basePrice, amountInStock, productStatus, productCode)
        {
            Color = color;
            Material = material;
            Waterproof = waterproof;
        }

        public override string DisplayProduct()
        {
            return $"FOOTWEAR\n" +
                   $"--------\n" +
                   $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nSale Price:{string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", SalePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus}\nProduct Code: {ProductCode}\n";

        }
    }
}
