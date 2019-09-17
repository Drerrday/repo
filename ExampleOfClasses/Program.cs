using System;

namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            prod.Name = "Nintendo Switch";
            prod.Price = 299.99;

            Console.WriteLine($"The Products name is {prod.Name} and it currently costs {prod.Price}.");
        }
    }
}
