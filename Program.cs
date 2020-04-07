using System;

namespace DotNetTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultClassTest = new  classes.ClassTest();
            var paramClasstest = new classes.ClassTest(10,"Params");
            var structTest = new classes.StructTest(3, "Struct");

            Console.WriteLine(defaultClassTest.ToString());
            Console.WriteLine(paramClasstest.ToString());
            Console.WriteLine(structTest.ToString());
        }
    }
}
