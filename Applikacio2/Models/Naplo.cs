using System;
using System.Collections.Generic;

#nullable disable

namespace Applikacio2
{
    public partial class Naplo
    {
        public int DokumentumId { get; set; }
        public int EsemenyId { get; set; }
        public DateTime HappenedAt { get; set; }

        public virtual Dokumentum Dokumentum { get; set; }
        public virtual Esemeny Esemeny { get; set; }
    }
}
