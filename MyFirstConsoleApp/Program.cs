using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not, Hello World

            Console.WriteLine("Welcome to Bangazon!!!");

            DateTime purchaseDate = DateTime.Now;
            Console.WriteLine(purchaseDate);

            string lastName = "Foster";

            var firstName = "Calvin";

            Console.WriteLine($"{firstName}{lastName} visited on {purchaseDate}");

            string[] products = new string[] { "bmw", "chevy", "gmc", "porsche", "cadillac", "i8" };

            foreach (string product in products)
            {
                if (product.Length > 4 )
                {
                    Console.WriteLine(product);
                }
            }

            // Accepting User Input 




        }
    }
}
