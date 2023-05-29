using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelsinkiWPF
{

    internal class HelsinkiClass
    {

        public int Helyezes { get; private set; }

        public int SportolokSzama { get; private set; }

        public string SportagNeve { get; private set; }

        public string VersenySzamNeve { get; private set; }

        public int Pontszam { get; set; }

        public HelsinkiClass(string sor)
        {
            string[] mezok = sor.Split(' ');
            Helyezes = Convert.ToInt32(mezok[0]);
            SportolokSzama = Convert.ToInt32(mezok[1]);
            SportagNeve = mezok[2];
            VersenySzamNeve = mezok[3];
            Pontszam = HelsinkiWPF.MainWindow.Helyezes(Convert.ToInt32(mezok[0]));
        }
    }
}
