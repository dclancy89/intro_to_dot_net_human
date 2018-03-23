using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human stan = new Human("Stan");
            Human hector = new Human("Hector", 5, 5, 5, 90);
            string x = "x";

            stan.attack(hector);
            stan.attack(x);
        }
    }
}
