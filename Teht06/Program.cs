using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double hinta = 1.595, kulutus = 7.02 / 100;
            Console.Write("Arvioitu matkan pituus? > ");
            matka = int.Parse(Console.ReadLine());
            double litrat = matka * kulutus;
            double yhteensä = litrat * hinta;
            Console.WriteLine("Ajetulla matkalla bensaa kuluu " + litrat + " litraa, ja hintalapuksi tulee " + yhteensä + " euroa");
            Console.ReadLine();
        }
    }
}