using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model;

namespace TicketApp
{
    public partial class BuyTicketForm : Form
    {
        private SocialEvent socialEvent;
        public BuyTicketForm(SocialEvent socialEvent)
        {
            InitializeComponent();
            this.socialEvent = socialEvent;

            textBoxTicketInformation.Text = socialEvent.ToString();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (numericUpDownTickets.Value <= socialEvent.GetAmountOfAvailableTickets())
            {
                MessageBox.Show("Available !");
            }
            else
            {
                MessageBox.Show("This event only has " + socialEvent.GetAmountOfAvailableTickets() + " tickets available.");
            }
        }
    }
}
