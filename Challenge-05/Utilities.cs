using System.Globalization;
using System.Text.RegularExpressions;

namespace CarvedRock.Backend
{
    internal class Utilities
    {
        public static Product? ReadProductFromTextFile(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string pattern = @"^[a-zA-Z0-9]+$";

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                sr.Close();
                 
                string[] parts = line.Split(';');
                int id = int.Parse(parts[0]);
                string name = parts[1];
                string description = parts[2];
                double basePrice = double.Parse(parts[3], new CultureInfo("en-US"));
                int amountInStock = int.Parse(parts[4]);
                ProductStatus status = Enum.Parse<ProductStatus>(parts[5]);
                string productCode = parts[6];

                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(productCode))
                {
                    productCode = string.Empty;
                }

                Product product = new(id, name, description, basePrice, amountInStock, status, productCode);

                return product;
            }
            return null;
        }
    }
}
