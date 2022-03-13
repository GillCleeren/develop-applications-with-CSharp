using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedRock.Backend
{
    public class Utilities
    {
        public static string CalculateSalePrice(double basePrice, int amountInStock, bool applyDiscount, 
            double marginOfProfit = 0.17, double discountPercentage = 0)
        {
            double salePrice = basePrice * (1 + marginOfProfit);

            if (amountInStock < 100)
            {
                salePrice *= 1.1;
            }

            if (applyDiscount && discountPercentage > 0 && discountPercentage <= 0.1)
                salePrice *= (1 - discountPercentage);

            //var r = String.Format("{0:C2}", salePrice);
            return string.Format(new System.Globalization.CultureInfo("en-US"), "{0:C2}", salePrice);
        }

    }
}
