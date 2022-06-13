using System;

namespace CS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vladimir";
            string surname = "Hohlov";
            (name, surname) = (surname, name);
            Console.WriteLine($"{surname}, {name}.");
            Console.WriteLine($"{name}, {surname}.");
        }
    }
}
