﻿using Library.Model;
using Library.Payment;
using Library.PersistenceAdapter;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class BuyTicketForm : Form
    {
        private SocialEvent socialEvent;
        private ITargetPersistenceAdapter persistenceAdapter;
        public BuyTicketForm(ITargetPersistenceAdapter persistenceAdapter, SocialEvent socialEvent)
        {
            InitializeComponent();
            this.persistenceAdapter = persistenceAdapter;
            this.persistenceAdapter.GetAll(this.persistenceAdapter.GetUnitOfWork().TicketRepository).ToList();
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
                for(int i = 0; i < numberOfTickets; i++)
                {
                    new Ticket(socialEvent);
                }

                UpdateAvailableTicketsTextBox();
                MessageBox.Show("Successfully bought tickets", paymentMethod.ToString());
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
            textBoxSocialEventDescription.Text = socialEvent.ToString();
            UpdateAvailableTicketsTextBox();
            UpdateToPayTextBox();
            textBoxPricePerTicket.Text = socialEvent.PricePerTicket + "kr";

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
            textBoxTicketsAvailable.Text = socialEvent.GetAmountOfAvailableTickets() + "/" + socialEvent.MaxTickets;
        }

        private void UpdateToPayTextBox()
        {
            textBoxToPay.Text = (socialEvent.PricePerTicket * NumericUpDownTickets.Value) + "kr";
        }

    }
}
