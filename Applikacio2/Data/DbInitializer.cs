using Applikacio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Applikacio2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Document
            if (context.Documents.Any())
            {
                return;   // DB has been seeded
            }

            var documents = new Document[]
            {
            new Document{Title="Szamlak_20200112153545",Extension="pdf", MainID=0, Source="scan"},
            new Document{Title="Szamla_20200112153545_1",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_2",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_3",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_4",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_5",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_6",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamla_20200112153545_7",Extension="pdf", MainID=1, Source="split"},
            new Document{Title="Szamlak_20200115132432",Extension="pdf", MainID=0, Source="mail"},
            new Document{Title="Szamlak_20200116135412",Extension="pdf", MainID=0, Source="scan"},
            new Document{Title="Szamla_20200116135412_1",Extension="pdf", MainID=10, Source="split"},
            new Document{Title="Szamla_20200116135412_2",Extension="pdf", MainID=10, Source="split"},
            new Document{Title="Szamla_20200116135412_3",Extension="pdf", MainID=10, Source="split"},
            new Document{Title="Jovahagyas_TesztElek_EV",Extension="pdf", MainID=0, Source="mail"},
            new Document{Title="Jovahagyott_tetellista",Extension="xls", MainID=0, Source="mail"},
            new Document{Title="Szallito_FuvarBt_20200214",Extension="pdf", MainID=0, Source="scan"},
            new Document{Title="Szallito_FuvarBt_20200216",Extension="pdf", MainID=0, Source="mail"}
            };
            foreach (Document d in documents)
            {
                context.Documents.Add(d);
            }
            context.SaveChanges();

            var events = new Event[]
            {
            new Event{Title="Beerkezes"},
            new Event{Title="Letrehozas"},
            new Event{Title="Kepjavitas"},
            new Event{Title="Szeparalas"},
            new Event{Title="OCR"},
            new Event{Title="Adatkinyeres"},
            new Event{Title="Athelyezes feltoltesre"},
            new Event{Title="Adatcsomag keszites"},
            new Event{Title="Feltoltes"},
            new Event{Title="Muvelet befejezve"},
            new Event{Title="Mappa muvelet hiba"},
            new Event{Title="Hianyos adatreteg"},
            new Event{Title="Sikertelen feltoltes"},
            new Event{Title="Athelyezes sikertelen mappaba"}
            };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();

            var logs = new Log[]
            {
            new Log{DocumentID=1,EventID=1,HappenedAt=DateTime.Parse("2020-01-12 15:35:00")},
            new Log{DocumentID=1,EventID=4,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=1,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=2,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=3,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=4,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=5,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=6,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=7,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=8,EventID=2,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=2,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=2,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=2,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=2,EventID=7,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=2,EventID=8,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=2,EventID=9,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=2,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=3,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=3,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=3,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=3,EventID=7,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=3,EventID=8,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=3,EventID=9,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=3,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=4,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=4,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=4,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=4,EventID=7,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=4,EventID=8,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=4,EventID=9,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=4,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=5,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=5,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=5,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=5,EventID=7,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=5,EventID=8,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=5,EventID=9,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=5,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=6,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=6,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=6,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=6,EventID=7,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=6,EventID=8,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=6,EventID=9,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=6,EventID=10,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=7,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=7,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=7,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=7,EventID=12,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=7,EventID=14,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=8,EventID=3,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=8,EventID=5,HappenedAt=DateTime.Parse("2020-01-12 15:39:00")},
            new Log{DocumentID=8,EventID=6,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=8,EventID=12,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=8,EventID=14,HappenedAt=DateTime.Parse("2020-01-12 15:40:00")},
            new Log{DocumentID=9,EventID=1,HappenedAt=DateTime.Parse("2020-01-15 13:24:00")},
            new Log{DocumentID=9,EventID=3,HappenedAt=DateTime.Parse("2020-01-15 13:24:00")},
            new Log{DocumentID=9,EventID=5,HappenedAt=DateTime.Parse("2020-01-15 13:24:00")},
            new Log{DocumentID=9,EventID=6,HappenedAt=DateTime.Parse("2020-01-15 13:24:00")},
            new Log{DocumentID=9,EventID=7,HappenedAt=DateTime.Parse("2020-01-15 13:27:00")},
            new Log{DocumentID=9,EventID=8,HappenedAt=DateTime.Parse("2020-01-15 13:27:00")},
            new Log{DocumentID=9,EventID=9,HappenedAt=DateTime.Parse("2020-01-15 13:27:00")},
            new Log{DocumentID=9,EventID=13,HappenedAt=DateTime.Parse("2020-01-15 13:28:00")},
            new Log{DocumentID=9,EventID=14,HappenedAt=DateTime.Parse("2020-01-15 13:28:00")},
            new Log{DocumentID=10,EventID=1,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=10,EventID=4,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=10,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=2,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=12,EventID=2,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=13,EventID=2,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=3,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=5,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=6,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=7,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=8,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=9,HappenedAt=DateTime.Parse("2020-01-16 13:54:00")},
            new Log{DocumentID=11,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=3,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=5,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=6,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=7,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=8,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=12,EventID=9,HappenedAt=DateTime.Parse("2020-01-16 13:56:00")},
            new Log{DocumentID=12,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=3,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=5,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=6,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=7,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=8,HappenedAt=DateTime.Parse("2020-01-16 13:55:00")},
            new Log{DocumentID=13,EventID=9,HappenedAt=DateTime.Parse("2020-01-16 13:56:00")},
            new Log{DocumentID=13,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 13:56:00")},
            new Log{DocumentID=14,EventID=1,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=3,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=5,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=6,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=7,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=8,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=9,HappenedAt=DateTime.Parse("2020-01-16 16:25:00")},
            new Log{DocumentID=14,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 16:26:00")},
            new Log{DocumentID=15,EventID=1,HappenedAt=DateTime.Parse("2020-01-16 16:40:00")},
            new Log{DocumentID=15,EventID=7,HappenedAt=DateTime.Parse("2020-01-16 16:40:00")},
            new Log{DocumentID=15,EventID=9,HappenedAt=DateTime.Parse("2020-01-16 16:40:00")},
            new Log{DocumentID=15,EventID=10,HappenedAt=DateTime.Parse("2020-01-16 16:40:00")},
            new Log{DocumentID=16,EventID=1,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=3,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=5,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=6,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=7,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=8,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=9,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=16,EventID=10,HappenedAt=DateTime.Parse("2020-02-14 11:54:00")},
            new Log{DocumentID=17,EventID=1,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=3,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=5,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=6,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=7,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=8,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=9,HappenedAt=DateTime.Parse("2020-02-16 14:54:00")},
            new Log{DocumentID=17,EventID=13,HappenedAt=DateTime.Parse("2020-02-16 14:55:00")},
            new Log{DocumentID=17,EventID=14,HappenedAt=DateTime.Parse("2020-02-16 14:55:00")}
            };
            foreach (Log l in logs)
            {
                context.Logs.Add(l);
            }
            context.SaveChanges();
        }
    }
}
