using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myThing = new { Stuff = "Calvin", otherproperty = 123 };

            Console.WriteLine("Hello World!");
            Console.WriteLine(myThing.Stuff);
        }
    }
}
