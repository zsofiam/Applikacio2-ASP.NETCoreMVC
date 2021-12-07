using System;


namespace Applikacio2.Models
{
    public class Log
    {
        public int ID { get; set; }
        public int DocumentID { get; set; }
        public int EventID { get; set; }

        public Document Document { get; set; }
        public Event Event { get; set; }

        public DateTime HappenedAt { get; set; }

        
    }
}
