namespace CarvedRock.Backend
{
    public class ClimbingFootwear : Footwear
    {
        public string ClimbingType { get; set; }

        public ClimbingFootwear(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus, string productCode, string color, string material, bool waterproof, string climbingType) : base(id, name, description, basePrice, amountInStock, productStatus, productCode, color, material, waterproof)
        {
            ClimbingType = climbingType;
        }

        public override string DisplayProduct()
        {
            return $"CLIMBING FOOTWEAR\n" +
                   $"-----------------\n" +
                   $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nSale Price:{string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", SalePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus.GetDescription()}\nProduct Code: {ProductCode}\n";
        }
    }
}
