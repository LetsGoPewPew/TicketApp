using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Ticket
    {
        public int id { get; }
        public Ticket(int id)
        {
            this.id = id;
        }
    }
}