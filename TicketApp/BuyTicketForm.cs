using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model;

namespace TicketApp
{
    public partial class BuyTicketForm : Form
    {
        private SocialEvent socialEvent;
        private List<TextBox> textBoxesToCheckIfEmpty = new List<TextBox>();
        public BuyTicketForm(SocialEvent socialEvent)
        {
            InitializeComponent();
            this.socialEvent = socialEvent;

            InitializeInfo();
            
            textBoxesToCheckIfEmpty.Add(textBoxCardCode);
            textBoxesToCheckIfEmpty.Add(textBoxCardNumber);

        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            if (numericUpDownTickets.Value <= socialEvent.GetAmountOfAvailableTickets())
            {
                if(RequiredInformationIsProvided())
                { 
                    CreditCard creditCard = new CreditCard(textBoxCardNumber.Text, textBoxCardCode.Text, textBoxExpirationMonth.Text, textBoxExpirationYear.Text);

                    if (socialEvent.BuyTickets(Decimal.ToInt32(numericUpDownTickets.Value), creditCard))
                    {
                        UpdateAvailableTicketsTextBox();
                        MessageBox.Show("Transaction successfull, email has been sent with the ticket. Remaining moneys: " + creditCard.MoneyAvailable + "kr");
                    }
                    else
                    {
                        MessageBox.Show("Transaction failed! (moneys remaining:" + creditCard.MoneyAvailable + "kr)");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill inn required information");
                }
            }
            else
            {
                MessageBox.Show("This event only has " + socialEvent.GetAmountOfAvailableTickets() + " tickets available.");
            }
        }

        private bool RequiredInformationIsProvided()
        {
            foreach (var textBox in textBoxesToCheckIfEmpty)
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }
            }

            return true;
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
