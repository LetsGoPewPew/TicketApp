using Library.Logic;
using Library.Model;
using Library.Payment;
using System;
using System.Data;
using System.Drawing;
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
            dynamic paymentMethod = ComboPaymentMethod.SelectedItem;
            IPayment IpaymentMethod = (IPayment)paymentMethod;

            int numberOfTickets = (int)NumericUpDownTickets.Value;
            if(numberOfTickets > socialEvent.GetAmountOfAvailableTickets())
            {
                MessageBox.Show($"Only {socialEvent.GetAmountOfAvailableTickets()} tickets available!");
                return;
            }

            if (PaymentLogic.Pay(paymentMethod, socialEvent.Name, numberOfTickets))
            {
                for(int i = 0; i < numberOfTickets; i++)
                {
                    new Ticket(socialEvent);
                }
                SocialEventLogic.BuyTickets(paymentMethod, numberOfTickets, socialEvent.PricePerTicket);

                UpdateAvailableTicketsTextBox();
                MessageBox.Show("Successfully bought tickets", IpaymentMethod.ToString());
            }
            else
                MessageBox.Show("Failed to buy tickets", IpaymentMethod.ToString());
        }

        private void NumericUpDownTickets_ValueChanged(object sender, EventArgs e)
        {
            UpdateToPayTextBox();
        }

        private void InitializeInfo()
        {
            textBoxSocialEventDescription.Text = socialEvent.ToString();
            UpdateAvailableTicketsTextBox();
            UpdateToPayTextBox();
            textBoxPricePerTicket.Text = socialEvent.PricePerTicket + "kr";

            var paymentMethods = Assembly.GetAssembly(typeof(IPayment)).GetTypes()
                .Where(myType => myType.GetInterfaces().Contains(typeof(IPayment)));

            foreach(Type paymentMethod in paymentMethods)
            {
                ComboPaymentMethod.Items.Add(Activator.CreateInstance(paymentMethod, true));
            }
            if (ComboPaymentMethod.Items.Count > 0)
                ComboPaymentMethod.SelectedIndex = 0;
        }

        private void UpdateAvailableTicketsTextBox()
        {
            textBoxTicketsAvailable.Text = socialEvent.GetAmountOfAvailableTickets() + "/" + socialEvent.MaxTickets;
        }

        private void UpdateToPayTextBox()
        {
            textBoxToPay.Text = (socialEvent.PricePerTicket * NumericUpDownTickets.Value) + "kr";
        }

    }
}
