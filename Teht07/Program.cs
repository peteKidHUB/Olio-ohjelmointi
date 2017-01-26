using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("anna jokin vuosiluku > ");
            int vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 400 == 0)
                Console.WriteLine("vuosi " + vuosi + " on karkausvuosi");
            else if (vuosi % 4 == 0 && vuosi % 100 != 0)
                Console.WriteLine("vuosi " + vuosi + " on karkausvuosi");
            else
                Console.WriteLine("vuosi " + vuosi + " ei ole karkausvuosi");
            Console.ReadLine();

        }
    }
}