using System.Collections.Generic;

namespace Library.Model
{
    public class SocialEvent
    {
        private static int numberOfSocialEventsCreated = 0;

        private int pricePerTicket;
        public int PricePerTicket { get => pricePerTicket; set => pricePerTicket = value; }

        private string location;
        public string Location { get => location; set => location = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string category;
        public string Category { get => category; set => category = value; }

        private int maxTickets;
        public int MaxTickets { get => maxTickets; set => maxTickets = value; }

        private List<Ticket> ticketsForThisSocialEvent = new List<Ticket>();
        public List<Ticket> TicketsForThisSocialEvent { get => ticketsForThisSocialEvent; set => ticketsForThisSocialEvent = value; }
        
        private static List<SocialEvent> socialEventList = new List<SocialEvent>();
        public static List<SocialEvent> SocialEventList { get => socialEventList; set => socialEventList = value; }

        private Organizer organizer;
        public Organizer Organizer { get => organizer; set => organizer = value; }

        private int id;
        public int Id { get => id; private set => id = value; }

        public SocialEvent()
        {
            Id = numberOfSocialEventsCreated++;
            socialEventList.Add(this);
        }

        public SocialEvent(int maxTickets, int pricePerTicket, Organizer organizer, string category = "", string name = "")
        {
            this.MaxTickets = maxTickets;
            this.Category = category;
            this.organizer = organizer;
            this.Name = name;
            this.PricePerTicket = pricePerTicket;
            Id = numberOfSocialEventsCreated++;
            socialEventList.Add(this);
        }

        public int GetAmountOfAvailableTickets()
        {
            return maxTickets - ticketsForThisSocialEvent.Count;
        }

        public override string ToString()
        {
            return name;
        }    
    }
}
