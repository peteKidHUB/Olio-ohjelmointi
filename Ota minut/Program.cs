using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysy luku
            int luku;
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine()); //parsitaan stringistä kokonaisluku

            switch (luku)
            {
                case 1: Console.WriteLine("Yksi"); break;
                case 2: Console.WriteLine("Kaksi"); break;
                case 3: Console.WriteLine("Kolmonen"); break;
                default: Console.WriteLine("Joku muu"); break;
            }

            Console.ReadLine();
        }
    }
}
