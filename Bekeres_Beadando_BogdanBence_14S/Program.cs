using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg hány számot szeretne: ");
            string darabszam = Console.ReadLine();
            int darab;
            bool szame = false;
            do
            {
                if (int.TryParse(darabszam, out darab))
                {
                    szame = true;
                }
                else
                {
                    Console.Write("Számot adjon meg!: ");
                }
            } while (szame == false);
            int[] szamok = new int[darab];
            for (int i = 0; i < szamok.Length;)
            {
                szame = false;
                int szam;
                do
                {
                    Console.Write("Adja meg a {0}. számot: ", i + 1);
                    string beker = Console.ReadLine();
                    if (int.TryParse(beker, out szam))
                    {
                        szame = true;
                        szamok[i] = szam;

                    }
                    else
                    {
                        Console.Write("Számot adjon meg! : ");
                    }
                } while (szame == false);
                i++;
            }
            Console.WriteLine("Legkisebb szám: " + szamok.Min());
            Console.WriteLine("Legnagyobb szám: " + szamok.Max());
            Console.ReadLine();

        }
    }
}