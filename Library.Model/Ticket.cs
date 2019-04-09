using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Ticket
    {
        private static int numberOfTicketsCreated = 0;

        private SocialEvent socialEvent;
        public SocialEvent SocialEvent { get => socialEvent; private set => socialEvent = value; }

        private string date;
        public string Date { get => date; set => date = value; }

        private int id;
        public int Id { get => id; private set => id = value; }

        private int eventId;
        public int EventId { get => eventId; set => eventId = value; }

        private bool isValid = true;
        public bool IsValid { get => isValid; set => isValid = value; }

        public Ticket()
        {
            id = numberOfTicketsCreated++;
        }

        public Ticket(SocialEvent socialEvent)
        {
            this.socialEvent = socialEvent;
            id = numberOfTicketsCreated++;
            socialEvent.TicketsForThisSocialEvent.Add(this);
        }

        public bool Verify(int eventId)
        {
            if (socialEvent.Id == eventId)
            {
                IsValid = false;
                return true;
            }

            return false;
        }
    }
}