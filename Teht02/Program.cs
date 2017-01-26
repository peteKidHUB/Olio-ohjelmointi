using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.Write("Paljonko pisteita sait? ");
            pisteet = int.Parse(Console.ReadLine());

            switch (pisteet)
            {
                case 0:
                case 1: Console.WriteLine("Sait nollan"); break;

                case 2:
                case 3: Console.WriteLine("Sait ykkosen"); break;

                case 4:
                case 5: Console.WriteLine("Sait kakosen"); break;

                case 6:
                case 7: Console.WriteLine("Sait kolmosen"); break;

                case 8:
                case 9: Console.WriteLine("Sait nelosen"); break;

                case 10:
                case 11:
                case 12: Console.WriteLine("Sait viitosen GRATZ"); break;

                default: Console.WriteLine("Mitahan kummaa?"); break;



            }
        }
    }
}