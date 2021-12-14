using System;
using System.Collections.Generic;

#nullable disable

namespace Applikacio2
{
    public partial class Esemeny
    {
        public Esemeny()
        {
            Naplos = new HashSet<Naplo>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Naplo> Naplos { get; set; }
    }
}
