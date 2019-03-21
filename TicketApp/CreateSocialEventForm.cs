using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class CreateSocialEventForm : Form
    {
        User CurrentUser = null;
        public CreateSocialEventForm(User currentUser)
        {
            CurrentUser = currentUser;

            InitializeComponent();
        }

        private void ButtonCreateSocialEvent_Click(object sender, EventArgs e)
        {
            
        }

        // public SocialEvent(int maxTickets, int pricePerTicket, string category = "", string name = ""
    }
}
