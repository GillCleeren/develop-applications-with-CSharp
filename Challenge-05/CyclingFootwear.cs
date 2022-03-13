namespace CarvedRock.Backend
{
    public class CyclingFootwear : Footwear
    {
        public string CyclingType { get; set; }

        public CyclingFootwear(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus, string productCode, string color, string material, bool waterproof, string cyclingType) : base(id, name, description, basePrice, amountInStock, productStatus, productCode, color, material, waterproof)
        {
            CyclingType = cyclingType;
        }

        public override string DisplayProduct()
        {
            return $"CYCLING FOOTWEAR\n" +
                   $"----------------\n" +
                   $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nSale Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", SalePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus}\nProduct Code: {ProductCode}\n";

        }
    }
}
