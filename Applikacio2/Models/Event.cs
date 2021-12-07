using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Applikacio2.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
