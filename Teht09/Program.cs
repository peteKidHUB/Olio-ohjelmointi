using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, autan sinua summaamaan kokonaislukusi");
            int luku = 1, summa = 0;
            while (luku != 0)
            {

                Console.WriteLine("Anna lukuja. lopeta nollalla (0) ");
                luku = int.Parse(Console.ReadLine());
                summa = summa + luku;
            }
            Console.Write(summa);
            Console.ReadLine();

        }

    }
}