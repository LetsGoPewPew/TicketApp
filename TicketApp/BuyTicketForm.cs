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

            InitializeInfo();
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            if (numericUpDownTickets.Value <= socialEvent.GetAmountOfAvailableTickets())
            {
                if (socialEvent.BuyTickets(Decimal.ToInt32(numericUpDownTickets.Value)))
                {
                    UpdateAvailableTicketsTextBox();
                    MessageBox.Show("Transaction successfull, email has been sent with the ticket");
                };
            }
            else
            {
                MessageBox.Show("This event only has " + socialEvent.GetAmountOfAvailableTickets() + " tickets available.");
            }
        }

        private void numericUpDownTickets_ValueChanged(object sender, EventArgs e)
        {
            UpdateToPayTextBox();
        }

        private void InitializeInfo()
        {
            textBoxSocialEventDescription.Text = socialEvent.ToString();
            UpdateAvailableTicketsTextBox();
            UpdateToPayTextBox();
            textBoxPricePerTicket.Text = socialEvent.PricePerTicket + "kr";
        }

        private void UpdateAvailableTicketsTextBox()
        {
            textBoxTicketsAvailable.Text = socialEvent.GetAmountOfAvailableTickets() + "/" + socialEvent.MaxTickets;
        }

        private void UpdateToPayTextBox()
        {
            textBoxToPay.Text = (socialEvent.PricePerTicket * numericUpDownTickets.Value) + "kr";
        }

    }
}
