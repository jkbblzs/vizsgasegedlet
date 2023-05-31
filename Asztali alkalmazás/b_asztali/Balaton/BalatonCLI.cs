using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaton
{
    public class BalatonCLI
    {
        public static int a_adosav = 800;
        public static int b_adosav = 600;
        public static int c_adosav = 100;
        public static int Ado(string adosav, int alapterulet)
        {
            int fizetendoAdo = 0;
            if (adosav=="A")
            {
                fizetendoAdo = a_adosav * alapterulet;
            }
            if (adosav == "B")
            {
                fizetendoAdo = b_adosav * alapterulet;
            }
            if (adosav == "C")
            {
                fizetendoAdo = c_adosav * alapterulet;
            }
            if (fizetendoAdo < 10000)
            {
                return 0;
            }
            else
            {
                return fizetendoAdo;
            }
        }

        static void Main(string[] args)
        {
            List<Balaton_Adatok> list = new List<Balaton_Adatok>();
            StreamReader reader = new StreamReader("utca.txt");
            string[] adosavok=reader.ReadLine().Split(' ');
            a_adosav = int.Parse(adosavok[0]);
            b_adosav = int.Parse(adosavok[1]);
            c_adosav = int.Parse(adosavok[2]);
            while (!reader.EndOfStream)
            {
                Balaton_Adatok egyAdat = new Balaton_Adatok(reader.ReadLine());
                list.Add(egyAdat);
            }
            reader.Close();

            Console.WriteLine($"2. feladat. A mintában {list.Count} telek szerepel.");

            string bekertAdoszam;
            Console.Write($"3. feladat. Egy tulajdonos adószáma: ");
            bekertAdoszam = Console.ReadLine();
            bool talalat = false;
            foreach (var item in list)
            {
                if (bekertAdoszam==item.Adoszam)
                {
                    Console.WriteLine($"{item.UtcaNeve} utca {item.HazSzam}");
                    talalat= true;
                }
            }
            if (!talalat)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }

            /*Dictionary<string, int> telkekAdosavonkent = new Dictionary<string, int>();
            Dictionary<string, int> fizetendoAdosavonkent = new Dictionary<string, int>();
            foreach (var item in adatok)
            {
                if (telkekAdosavonkent.ContainsKey(item.AdoKategoria))
                {
                    telkekAdosavonkent[item.AdoKategoria] += 1;
                }
                else
                {
                    telkekAdosavonkent[item.AdoKategoria] = 1;
                }

                if (fizetendoAdosavonkent.ContainsKey(item.AdoKategoria))
                {
                    fizetendoAdosavonkent[item.AdoKategoria] += Ado(item.AdoKategoria, item.Terulet);
                }
                else
                {
                    fizetendoAdosavonkent[item.AdoKategoria] = Ado(item.AdoKategoria, item.Terulet);
                }
            }
            foreach (var item in telkekAdosavonkent)
            {
                Console.WriteLine($"{item.Key} sávba {item.Value} telek esik, az adó {fizetendoAdosavonkent[item.Key]}");
            }
            */

            int A_Telkek = 0;
            int B_Telkek = 0;
            int C_Telkek = 0;
            int A_Telkek_Fizetendo = 0;
            int B_Telkek_Fizetendo = 0;
            int C_Telkek_Fizetendo = 0;
            int fizetendoAdo = 0;

            foreach (var item in list)
            {
                if (item.AdoSav=="A")
                {
                    A_Telkek++;
                    fizetendoAdo = Ado(item.AdoSav, item.Alapterulet);
                    A_Telkek_Fizetendo += fizetendoAdo;
                }
                if (item.AdoSav == "B")
                {
                    B_Telkek++;
                    fizetendoAdo = Ado(item.AdoSav, item.Alapterulet);
                    B_Telkek_Fizetendo += fizetendoAdo;
                }
                if (item.AdoSav == "C")
                {
                    C_Telkek++;
                    fizetendoAdo = Ado(item.AdoSav, item.Alapterulet);
                    C_Telkek_Fizetendo += fizetendoAdo;
                }
            }
            Console.WriteLine("5. feladat: ");
            Console.WriteLine($"A sávba {A_Telkek} telek esik, az adó {A_Telkek_Fizetendo} Ft.");
            Console.WriteLine($"B sávba {B_Telkek} telek esik, az adó {B_Telkek_Fizetendo} Ft.");
            Console.WriteLine($"C sávba {C_Telkek} telek esik, az adó {C_Telkek_Fizetendo} Ft.");

            StreamWriter writer = new StreamWriter("teljes.txt");
            foreach (var item in list)
            {
                writer.WriteLine($"{item.Adoszam} {item.UtcaNeve} {item.HazSzam} {item.AdoSav} {item.Alapterulet} {Ado(item.AdoSav, item.Alapterulet)}");
            }
            writer.Close();
            Console.ReadKey();
        }
    }
}
