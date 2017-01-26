using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet1, pisteet2, pisteet3, pisteet4, pisteet5, pisteet_yht, KOKO, max_pisteet, min_pisteet;
            Console.Write("Anna pisteet > ");
            pisteet1 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            pisteet2 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            pisteet3 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            pisteet4 = int.Parse(Console.ReadLine());
            Console.Write("Anna pisteet > ");
            pisteet5 = int.Parse(Console.ReadLine());
            int[] kaikki_pisteet = { pisteet1, pisteet2, pisteet3, pisteet4, pisteet5 };
            max_pisteet = kaikki_pisteet.Max();
            min_pisteet = kaikki_pisteet.Min();
            pisteet_yht = kaikki_pisteet.Sum();
            KOKO = pisteet_yht - max_pisteet - min_pisteet;
            Console.WriteLine("Kokonaispisteet ovat: " + KOKO);

            Console.ReadLine();
        }
    }
}