using System;
using System.Collections.Generic;


namespace Applikacio2.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public int MainID { get; set; }
        public string Source { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
