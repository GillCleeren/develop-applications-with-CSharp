using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedRock.Backend
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double BasePrice { get; set; }
        public int AmountInStock { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public double SalePrice { get; set; }
        public string ProductCode { get; set; }

        public Product(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus, string productCode)
        {
            Id = id;
            Name = name;
            Description = description;
            BasePrice = basePrice;
            AmountInStock = amountInStock;
            ProductStatus = productStatus;
            ProductCode = productCode;

            CalculateSalePrice(false);
        }

        public virtual string DisplayProduct()
        {
            return $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nSale Price:{string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", SalePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus.GetDescription()}\nProduct Code: {ProductCode}\n";
        }

        public void CalculateSalePrice(bool applyDiscount, double marginOfProfit = 0.17, double discountPercentage = 0)
        {
            SalePrice = BasePrice * (1 + marginOfProfit);

            if (AmountInStock < 100)
            {
                SalePrice *= 1.1;
            }

            if (applyDiscount && discountPercentage > 0 && discountPercentage <= 0.1)
                SalePrice *= (1 + discountPercentage);

            SalePrice = Math.Round(SalePrice, 2);
        }
    }
}