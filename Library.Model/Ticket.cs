using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Ticket
    {
        public int Id { get; }
        public int EventId { get; }

        public bool IsValid { get; set; } = true;

        public Ticket(int id, int eventId)
        {
            this.Id = id;
            this.EventId = eventId;
        }

        public bool Verify(int eventId)
        {
            if (this.EventId == eventId)
            {
                this.IsValid = false;
                return true;
            }

            return false;
        }
    }
}