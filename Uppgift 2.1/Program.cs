using System;

namespace Uppgift2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken stad bor du i?");
            string plats = Console.ReadLine();
            Console.WriteLine("Vilket är ditt drömresemål?");
            string resemål = Console.ReadLine();
            Console.WriteLine("Hej " +  plats + "-bo. Hoppas du får resa till " + resemål);
        }
    }
}