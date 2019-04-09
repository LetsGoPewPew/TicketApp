using Library.Model;
using Library.PersistenceAdapter;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class SocialEventListForm : Form
    {
        private ITargetPersistenceAdapter persistenceAdapter;
        private User currentUser = null;
        public SocialEventListForm(ITargetPersistenceAdapter persistenceAdapter, User currentUser)
        {
            this.persistenceAdapter = persistenceAdapter;
            SocialEvent.SocialEventList = this.persistenceAdapter.GetAll(this.persistenceAdapter.GetUnitOfWork().SocialEventRepository).ToList();
            this.currentUser = currentUser;

            InitializeComponent();
            listBoxSocialEvents.DataSource = SocialEvent.SocialEventList;

            if(this.currentUser == null)
                this.Text = "Guest login";
            else
            {
                this.Text = $"Logged in as: {this.currentUser.Name}";
                if(this.currentUser.GetType() == typeof(Organizer))
                {
                    ButtonCreateSocialEvent.Visible = true;
                    this.Text += " (Organizer)";
                }
                else
                {
                    this.Text += " (Customer)";
                }

                if(this.currentUser.GetType() == typeof(Customer))
                {
                    ButtonVerify.Visible = true;
                }
            }
        }

        private void ButtonBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicket = new BuyTicketForm(persistenceAdapter, (SocialEvent)listBoxSocialEvents.SelectedItem)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            buyTicket.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(persistenceAdapter)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            loginForm.Show();
            this.Close();
        }

        private void ButtonCreateSocialEvent_Click(object sender, EventArgs e)
        {
            CreateSocialEventForm createSocialEventForm = new CreateSocialEventForm(persistenceAdapter, currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            createSocialEventForm.Show();
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            VerifyForm verifyForm = new VerifyForm(persistenceAdapter, currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            verifyForm.Show();
            this.Close();
        }

        private void ButtonRefreshSocialEventList_Click(object sender, EventArgs e)
        {
            listBoxSocialEvents.DataSource = null;
            listBoxSocialEvents.DataSource = SocialEvent.SocialEventList;
        }
    }
}