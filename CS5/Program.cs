using System;

namespace CS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vladimir";
            string family = "Hohlov";
            (name, family) = (family, name);
            Console.WriteLine($"{family}, {name}.");
            Console.WriteLine($"{name}, {family}.");
        }
    }
}