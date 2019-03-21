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
            if (AllFieldsFilledOut())
            {
                new SocialEvent((int)NumericUpDownTotalTickets.Value, (int)NumericUpDownTicketPrice.Value, TextBoxCategory.Text, TextBoxSocialEventName.Text);
                MessageBox.Show($"SocialEvent: {TextBoxSocialEventName.Text} created");
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
        }

        private bool AllFieldsFilledOut()
        {
            if(NumericUpDownTicketPrice.Value <= 0)
            {
                return false;
            }

            if(NumericUpDownTotalTickets.Value <= 0)
            {
                return false;
            }

            if (String.IsNullOrEmpty(TextBoxCategory.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(TextBoxSocialEventName.Text))
            {
                return false;
            }

            return true;
        }
    }
}
