using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayByDay_Notes.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }

    public class EventManager
    {
        public static List<Event> GetEvents()
        {
            var events = new List<Event>();

            events.Add(new Event
            { EventId = 1, Title = "Pusryciai", Content = "Issikepti kiausiniene", Date = "12 - 01 - 2017", Time = "9:00"});
            events.Add(new Event
            { EventId = 2, Title = "Priespieciai", Content = "Nusiplauti obuoli", Date = "12 - 01 - 2017", Time = "12:00" });
            events.Add(new Event
            { EventId = 3, Title = "Pietus", Content = "Issivirti makaronu", Date = "12 - 01 - 2017", Time = "14:00" });
            events.Add(new Event
            { EventId = 4, Title = "Pavakariai", Content = "Issikepti duonos", Date = "12 - 01 - 2017", Time = "16:00" });
            events.Add(new Event
            { EventId = 5, Title = "Vakariene", Content = "Issispausti varskes", Date = "12 - 01 - 2017", Time = "19:00" });

            return events;
        }
    }
}
