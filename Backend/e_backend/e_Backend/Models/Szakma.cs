using System;
using System.Collections.Generic;

#nullable disable

namespace Europass_Backend.Models
{
    public partial class Szakma
    {
        public Szakma()
        {
            Versenyzos = new HashSet<Versenyzo>();
        }

        public string Id { get; set; }
        public string SzakmaNev { get; set; }

        public virtual ICollection<Versenyzo> Versenyzos { get; set; }
    }
}
