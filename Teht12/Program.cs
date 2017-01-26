using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku1, luku2, luku3, luku4, luku5, i;
            Console.Write("anna luku 1 > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("anna luku 2 > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("anna luku 3 > ");
            luku3 = int.Parse(Console.ReadLine());
            Console.Write("anna luku 4 > ");
            luku4 = int.Parse(Console.ReadLine());
            Console.Write("anna luku 5 > ");
            luku5 = int.Parse(Console.ReadLine());
            int[] array = { luku1, luku2, luku3, luku4, luku5 };
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}