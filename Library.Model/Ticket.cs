using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Ticket
    {
        private static int numberOfTicketsCreated = 0;

        private int id;
        public int Id { get => id; set => id = value; }

        private int eventId;
        public int EventId { get => eventId; set => eventId = value; }

        private bool isValid = true;
        public bool IsValid { get => isValid; }

        public Ticket(int eventId)
        {
            this.eventId = eventId;
            this.id = numberOfTicketsCreated++;
        }

        public bool Verify(int eventId)
        {
            if (this.EventId == eventId)
            {
                this.isValid = false;
                return true;
            }

            return false;
        }
    }
}