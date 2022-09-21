﻿using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en veckodag: ");
            string input = Console.ReadLine().ToLower();
            string dayName = input.Substring(0,1);
            dayName = dayName.ToUpper();
            dayName += input.Substring(1);

            var tryParse = Enum.TryParse(typeof(Veckodagar), dayName, out var objThing);
            Veckodagar miniX = (Veckodagar)objThing;

            Console.WriteLine((int)miniX);

        }

        
    }
    public enum Veckodagar
    {
        Måndag = 1,
        Tisdag = 2,
        Onsdag,
        Tortsdag,
        Fredag,
        Lördag,
        Söndag

    }
}
