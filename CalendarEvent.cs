
using System;
using System.Drawing;

namespace ClubManager
{
    public class CalendarEvent
    {
        public string EventId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string ClubName { get; set; }
        public string Location { get; set; }
        public string DisplayColor { get; set; }

        public CalendarEvent() { }

        public CalendarEvent(string eventId, string title, DateTime startDate, string clubName, string location, string displayColor)
        {
            EventId = eventId;
            Title = title;
            StartDate = startDate;
            ClubName = clubName;
            Location = location;
            DisplayColor = displayColor;
        }

        public override string ToString()
        {
            return $"[{ClubName}] {Title} - {StartDate.ToShortTimeString()}";
        }
    }
}
