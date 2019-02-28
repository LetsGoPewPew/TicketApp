using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class SocialEvent
    {
        private static int numberOfSocialEventsCreated = 0;

        private static List<SocialEvent> socialEventList = new List<SocialEvent>();
        public static List<SocialEvent> SocialEventList { get => socialEventList; set => socialEventList = value; }

        private int id;
        public int Id { get => id; set => id = value; }
        public SocialEvent()
        {
            this.Id = numberOfSocialEventsCreated++;
            socialEventList.Add(this);
        }
    }
}
