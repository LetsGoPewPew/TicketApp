using Library.Model;
using Library.PersistenceAdapter;
using System;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class CreateSocialEventForm : Form
    {
        private ITargetPersistenceAdapter persistenceAdapter;
        private User currentUser = null;
        public CreateSocialEventForm(ITargetPersistenceAdapter persistenceAdapter, User currentUser)
        {
            this.persistenceAdapter = persistenceAdapter;
            this.currentUser = currentUser;

            InitializeComponent();
        }

        private void ButtonCreateSocialEvent_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilledOut())
            {
                SocialEvent newSocialEvent = new SocialEvent((int)NumericUpDownTotalTickets.Value,
                                                            (int)NumericUpDownTicketPrice.Value, (Organizer)currentUser, TextBoxCategory.Text, TextBoxSocialEventName.Text);
                persistenceAdapter.Add(persistenceAdapter.GetUnitOfWork().SocialEventRepository, newSocialEvent);
                persistenceAdapter.GetUnitOfWork().Commit();
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
