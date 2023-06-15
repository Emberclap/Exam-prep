using System.Diagnostics;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sumWithoutTaxes = 0m;
            
            
            while (input != "special" && input != "regular")
            {
                decimal partsPrice = decimal.Parse(input);
                if (partsPrice < 0 )
                {
                    Console.WriteLine($"Invalid price!");
                    
                }
                else
                {
                sumWithoutTaxes += partsPrice;

                }
                input = Console.ReadLine();
            }
            decimal taxes = sumWithoutTaxes * 0.20m;
            decimal totalPrice = taxes + sumWithoutTaxes;
            if (totalPrice <= 0 )
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (input == "special")
            {
                totalPrice *= 0.90m;
            } 
            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}