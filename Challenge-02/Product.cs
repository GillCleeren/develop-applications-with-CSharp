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
        public string Name { get; set; }
        public string Description { get; set; }
        public double BasePrice { get; set; }
        public int AmountInStock { get; set; }
        public ProductStatus ProductStatus { get; set; }

        public Product(int id, string name, string description, double basePrice, int amountInStock, ProductStatus productStatus)
        {
            Id = id;
            Name = name;
            Description = description;
            BasePrice = basePrice;
            AmountInStock = amountInStock;
            ProductStatus = productStatus;
        }

        public string DisplayProduct()
        {
            return $"Product ID: {Id}\nProduct name: {Name}\nDescription: {Description}\nBase Price: {string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", BasePrice)}\nAmount in stock: {AmountInStock}\nProduct status: {ProductStatus}\n";
        }

    }
}