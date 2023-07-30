//Даны две переменные. Поменять местами значения двух переменных. 
//Вывести на экран значения переменных до перестановки и после.
//К примеру, есть две переменные имя и фамилия, они сразу инициализированные, 
//но данные не верные, перепутанные. Вот эти данные и надо поменять местами через код.
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
