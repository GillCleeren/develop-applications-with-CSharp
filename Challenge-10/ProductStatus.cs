using System.ComponentModel;

namespace CarvedRock.Backend
{
    public enum ProductStatus
    {
        [Description("Coming soon")]
        ComingSoon,
        [Description("In stock")]
        InStock,
        [Description("Out of stock")]
        OutOfStock,
        [Description("Discontinued")]
        Discontinued
    }
}
