using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.Write("montako sekuntia? > ");
            time = int.Parse(Console.ReadLine());
            int tunti = (time / 3600);
            int sekunti = (time % 3600 % 60);
            int minuutti = (time % 3600 / 60);
            Console.Write(tunti + " tuntia" + " " + minuutti + " minuuttia ja" + sekunti + " sekuntia");
            Console.ReadLine();
        }
    }
}