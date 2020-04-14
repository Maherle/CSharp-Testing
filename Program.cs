using System;

namespace CSharp_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var propertyTest = new classes.PropertyTest("Maher", "Husein");
            propertyTest.Hours = 24;

            Console.WriteLine($"Time in hours: {propertyTest.Hours}");
            Console.WriteLine($"The name is: {propertyTest.Name}");
        }
    }
}
