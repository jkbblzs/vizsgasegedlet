using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    public class helsinki1952
    {
        public static int Helyezes(int helyezes)
        {
            int pontszam = 0;

            if (helyezes==1)
            {
                pontszam = 7;
            }
            else if (helyezes == 2)
            {
                pontszam = 5;
            }
            else if (helyezes == 3)
            {
                pontszam = 4;
            }
            else if (helyezes == 4)
            {
                pontszam = 3;
            }
            else if (helyezes == 5)
            {
                pontszam = 2;
            }
            else if (helyezes == 6)
            {
                pontszam = 1;
            }
            else
            {
                pontszam= 0;
            }
            return pontszam;
        }

        static void Main(string[] args)
        {
            List<helsinkiClass> list= new List<helsinkiClass>();

            StreamReader reader = new StreamReader("helsinki.txt");
            while(!reader.EndOfStream)
            {
                helsinkiClass egyrecord = new helsinkiClass(reader.ReadLine());
                list.Add(egyrecord);
            }
            reader.Close();

            Console.WriteLine("3. feladat: ");
            Console.WriteLine($"\tA magyar olimpikonok {list.Count} pontszerző helyezést értek el.");

            Console.WriteLine("5. feladat: ");
            int tornaPontszam = 0;
            foreach (var item in list)
            {
                if (item.SportagNeve=="torna")
                {
                    tornaPontszam+=Helyezes(item.Helyezes);
                }
            }
            Console.WriteLine($"\tA magyarok {tornaPontszam} pontot szereztek torna sportágban.");

            StreamWriter writer = new StreamWriter("foglalas.txt");
            int sportolokSzama = 0;
            foreach (var item in list)
            {
                sportolokSzama += item.SportolokSzama;
            }
            writer.WriteLine($"Szeretnék asztalokat foglalni {sportolokSzama} főre!");
            writer.Close();
            Console.ReadKey();
        }
    }
}
