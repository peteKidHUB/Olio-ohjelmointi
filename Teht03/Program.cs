using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.Write("Anna joku luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());
            float summa = (luku1 + luku2 + luku3);
            float keskiarvo = (summa / 3);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
            Console.ReadLine();
        }
    }
}
