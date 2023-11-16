using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputfc;
            double localcur;
            double uahcur;

            Converter currency = new Converter();
            currency.X = 37.55; //static cur. x y z to uah
            currency.Y = 40.5;
            currency.Z = 8.9;

            currency.H = 37.5; //static cur. uah to x y z
            currency.C = 40;
            currency.D = 8.7;


            Console.WriteLine("Options of convertaion: UAH --> USD, Euro, PLN; \n Select one currency:   UAH, USD, EUR, PLN.");
            inputfc = Console.ReadLine();

            if (inputfc == "USD")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n USD " + uahcur / currency.H);
                localcur = currency.Z;
            }
            else if (inputfc == "EUR")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n EUR " + uahcur / currency.C);
                localcur = currency.Y;
            }
            else if (inputfc == "PLN")
            {
                Console.WriteLine("\nHrivnas quantity:");
                uahcur = double.Parse(Console.ReadLine());

                Console.WriteLine("\nConvertation result:" + "\n PLN " + uahcur / currency.D);
                localcur = currency.X;
            }
            else if (inputfc == "UAH")
            {
                Console.WriteLine("\nIt's an option to convert other currencies: \n USD, Euro, PLN --> UAH " +
                    "\nType what exactly you want to convert: USD, EUR, PLN");
                inputfc = Console.ReadLine();
                if (inputfc == "USD")
                {
                    Console.WriteLine("\nUSD quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nConvertation result:" + "\n UAH " + uahcur * currency.X);
                }
                else if (inputfc == "EUR")
                {
                    Console.WriteLine("\nEUR quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nConvertation result:" + "\n UAH " + uahcur * currency.Y);
                }
                else if (inputfc == "PLN")
                {
                    Console.WriteLine("\nPLN quantity:");
                    uahcur = double.Parse(Console.ReadLine());

                    Console.WriteLine("Convertation result:" + "\n UAH " + uahcur / currency.Z);
                }
                else Console.WriteLine("\n **INPUT ERROR!**");
            }
            else
                Console.WriteLine("\n **INPUT ERROR!**");
        }
    }
}
