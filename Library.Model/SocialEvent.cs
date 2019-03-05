using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class SocialEvent
    {
        private static int numberOfSocialEventsCreated = 0;

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

        private int id;
        public int Id { get => id; private set => id = value; }
        public SocialEvent(int maxTickets, string category = "", string name = "")
        {
            this.Id = numberOfSocialEventsCreated++;
            this.maxTickets = maxTickets;
            this.category = category;
            this.name = name;
            socialEventList.Add(this);
        }

        public int GetAmountOfAvailableTickets()
        {
            return maxTickets - ticketsForThisSocialEvent.Count;
        }

        public override string ToString()
        {
            return name + " - Available tickets: " + GetAmountOfAvailableTickets() + "/" + maxTickets;
        }

        public bool BuyTickets(int amountOfTickets, User user = null)
        {
            //verify purchase
            //transaction success
            if(true)
            {
                for (int i = 0; i < amountOfTickets; i++)
                {
                    Ticket ticket = new Ticket(this);
                    if (user != null)
                    {
                        user.OwnedTickets.Add(ticket);
                    }
                }

                return true;
            }
            //transaction failed
            return false;

        }
        
        
    }
}
