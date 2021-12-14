using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Applikacio2.Models
{
    public class LoginEvent
    {
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime HappenedAt { get; set; }
        public string Username { get; set; }
        public string Result { get; set; }
        public int Counter { get; set; }
    }
}
