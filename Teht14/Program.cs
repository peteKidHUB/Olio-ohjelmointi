using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna arvosanoja nollasta viiteen. Peli loppuu jos annat jotakin muuta ");
            int numero;
            string as0 = "", as1 = "", as2 = "", as3 = "", as4 = "", as5 = "";
            while (true)

            {
                Console.WriteLine("Anna numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    as0 += "*";
                }
                else if (numero == 1)
                {
                    as1 += "*";
                }
                else if (numero == 2)
                {
                    as2 += "*";
                }
                else if (numero == 3)
                {
                    as3 += "*";
                }
                else if (numero == 4)
                {
                    as4 += "*";
                }
                else if (numero == 5)
                {
                    as5 += "*";
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("0: " + as0 + "\n" + "1: " + as1 + "\n" + "2: " + as2 + "\n" + "3: " + as3 + "\n" + "4: " + as4 + "\n" + "5: " + as5 + "\n");
            Console.ReadLine();




        }
    }
}