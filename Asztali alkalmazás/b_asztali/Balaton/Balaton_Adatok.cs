using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaton
{
    internal class Balaton_Adatok
    {
        public string Adoszam { get; private set; }

        public string UtcaNeve { get; private set; }

        public string HazSzam { get; private set; }

        public string AdoSav { get; private set; }

        public int Alapterulet { get; private set; }

        public Balaton_Adatok(string sor)
        {
            string[] mezok = sor.Split(' ');
            Adoszam = mezok[0];
            UtcaNeve = mezok[1];
            HazSzam = mezok[2];
            AdoSav = mezok[3];
            Alapterulet = Convert.ToInt32(mezok[4]);
        }
    }
}
