using Library.Model;
using Library.Payment;
using Library.PersistenceAdapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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
            IPaymentMethod paymentMethod = (IPaymentMethod)ComboPaymentMethod.SelectedItem;

            int numberOfTickets = (int)NumericUpDownTickets.Value;
            if(numberOfTickets > socialEvent.GetAmountOfAvailableTickets())
            {
                MessageBox.Show($"Only {socialEvent.GetAmountOfAvailableTickets()} tickets available!");
                return;
            }

            int price = numberOfTickets * socialEvent.PricePerTicket;
            if (paymentMethod.PayForItem(socialEvent.Name, price))
            {
                List<Ticket> tickets = new List<Ticket>();
                for(int i = 0; i < numberOfTickets; i++)
                {
                    tickets.Add(new Ticket(socialEvent));
                }

                UpdateAvailableTicketsTextBox();

                Receipt receipt = new Receipt(numberOfTickets, tickets[0], "nok", paymentMethod.ToString());
                MessageBox.Show(receipt.GenerateReceipt(), "Your purchase was successful");
            }
            else
                MessageBox.Show("Failed to buy tickets", paymentMethod.ToString());
        }

        private void NumericUpDownTickets_ValueChanged(object sender, EventArgs e)
        {
            UpdateToPayTextBox();
        }

        private void InitializeInfo()
        {
            LabelSocialEventDescription.Text = socialEvent.Name;
            TextBoxOrganizer.Text = socialEvent.Organizer.Name;
            UpdateAvailableTicketsTextBox();
            UpdateToPayTextBox();
            TextBoxPricePerTicket.Text = socialEvent.PricePerTicket + "kr";

            var paymentMethods = Assembly.GetAssembly(typeof(IPaymentMethod)).GetTypes()
                .Where(myType => myType.GetInterfaces().Contains(typeof(IPaymentMethod)));

            foreach(Type paymentMethod in paymentMethods)
            {
                ComboPaymentMethod.Items.Add(Activator.CreateInstance(paymentMethod, true));
            }
            if (ComboPaymentMethod.Items.Count > 0)
                ComboPaymentMethod.SelectedIndex = 0;
        }

        private void UpdateAvailableTicketsTextBox()
        {
            TextBoxTicketsAvailable.Text = socialEvent.GetAmountOfAvailableTickets() + "/" + socialEvent.MaxTickets;
        }

        private void UpdateToPayTextBox()
        {
            TextBoxToPay.Text = (socialEvent.PricePerTicket * NumericUpDownTickets.Value) + "kr";
        }

    }
}