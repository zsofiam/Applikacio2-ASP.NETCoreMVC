using System;
using System.Collections.Generic;

#nullable disable

namespace Applikacio2
{
    public partial class Dokumentum
    {
        public Dokumentum()
        {
            Naplos = new HashSet<Naplo>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public int MainId { get; set; }
        public string Source { get; set; }

        public virtual ICollection<Naplo> Naplos { get; set; }
    }
}
