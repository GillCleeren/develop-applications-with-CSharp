using System.Globalization;
using System.Text.RegularExpressions;

namespace CarvedRock.Backend
{
    public class Utilities
    {
        public static List<Product> ReadInventoryFile(string fileName)
        {
            string path = Path.Combine(Environment.CurrentDirectory, fileName);

            List<Product> products = new List<Product>();
            StreamReader sr = null;

            try
            {
                if (File.Exists(path))
                {

                    sr = new StreamReader(path);
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        products.Add(ParseProductLine(line));
                    }

                }
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine("An error occured while reading the file.");
                Console.WriteLine($"Error information: {fnfex.Message}");
            }
            catch (IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("The file contains an error.");
                Console.WriteLine($"Error information: {ioorex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured, no extra details exist.");
                Console.WriteLine($"Error information: {ex.Message}");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            return products;
        }

        private static Product ParseProductLine(string line)
        {
            string pattern = @"^[a-zA-Z0-9]+$";

            string[] parts = line.Split(';');
            int id = int.Parse(parts[0]);
            string name = parts[1];
            string description = parts[2];
            double price = double.Parse(parts[3], new CultureInfo("en-US"));
            int amountInStock = int.Parse(parts[4]);
            ProductStatus status = Enum.Parse<ProductStatus>(parts[5]);

            string productCode = parts[6];

            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(productCode))
            {
                productCode = string.Empty;
            }

            int type = int.Parse(parts[7]);

            string color;
            string material;
            bool waterproof;
            string climbingType;
            string cyclingType;
            string capacity;
            double weight;

            switch (type)
            {
                case 1:
                    return new Product(id, name, description, price, amountInStock, status, productCode);
                case 2:
                    color = parts[8];
                    material = parts[9];
                    waterproof = bool.Parse(parts[10]);
                    return new Footwear(id, name, description, price, amountInStock, status, productCode, color, material, waterproof); ;
                case 3:
                    color = parts[8];
                    material = parts[9];
                    waterproof = bool.Parse(parts[10]);
                    climbingType = parts[11];
                    return new ClimbingFootwear(id, name, description, price, amountInStock, status, productCode, color, material, waterproof, climbingType);
                case 4:
                    color = parts[8];
                    material = parts[9];
                    waterproof = bool.Parse(parts[10]);
                    cyclingType = parts[11];
                    return new CyclingFootwear(id, name, description, price, amountInStock, status, productCode, color, material, waterproof, cyclingType);
                case 5:
                    capacity = parts[8];
                    weight = double.Parse(parts[9], new CultureInfo("en-US"));
                    color = parts[10];
                    return new Bag(id, name, description, price, amountInStock, status, productCode, capacity, weight, color);
                default:
                    return null;
            }
        }
    }
}
