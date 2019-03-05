using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class SocialEvent
    {
        private static int numberOfSocialEventsCreated = 0;

        private int maxTickets;
        public int MaxTickets { get => maxTickets; set => maxTickets = value; }

        private List<Ticket> ticketsForThisSocialEvent = new List<Ticket>();
        public List<Ticket> TicketsForThisSocialEvent{ get => ticketsForThisSocialEvent; set => ticketsForThisSocialEvent = value; }
        
        private static List<SocialEvent> socialEventList = new List<SocialEvent>();
        public static List<SocialEvent> SocialEventList { get => socialEventList; set => socialEventList = value; }

        private int id;
        public int Id { get => id; private set => id = value; }
        public SocialEvent(int maxTickets)
        {
            this.Id = numberOfSocialEventsCreated++;
            this.maxTickets = maxTickets;
            socialEventList.Add(this);
        }

        public int GetAmountOfAvailableTickets()
        {
            return maxTickets - ticketsForThisSocialEvent.Count;
        }
    }
}
