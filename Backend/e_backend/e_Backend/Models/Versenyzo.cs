using System;
using System.Collections.Generic;

#nullable disable

namespace Europass_Backend.Models
{
    public partial class Versenyzo
    {
        //Scaffold-DbContext "server=localhost;database=********;user=root;password=;ssl mode = none;"mysql.entityframeworkcore -outputdir Models –f
        public int Id { get; set; }
        public string Nev { get; set; }
        public string SzakmaId { get; set; }
        public string OrszagId { get; set; }
        public int Pont { get; set; }

        public virtual Orszag Orszag { get; set; }
        public virtual Szakma Szakma { get; set; }
    }
}
