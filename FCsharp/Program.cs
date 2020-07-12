using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}

        }
    }
}
