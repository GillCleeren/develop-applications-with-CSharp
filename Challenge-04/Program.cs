

using CarvedRock.Backend;

Product climbingShoes = Utilities.ReadProductFromTextFile("product1.txt");

if (climbingShoes != null)
{
    Console.WriteLine(climbingShoes.DisplayProduct());
}   
