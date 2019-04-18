using Library.Model;
using System;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class SocialEventListForm : Form
    {
        private User currentUser = null;
        public SocialEventListForm(User currentUser)
        {
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
            BuyTicketForm buyTicket = new BuyTicketForm((SocialEvent)listBoxSocialEvents.SelectedItem)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            buyTicket.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            loginForm.Show();
            this.Hide();
        }

        private void ButtonCreateSocialEvent_Click(object sender, EventArgs e)
        {
            CreateSocialEventForm createSocialEventForm = new CreateSocialEventForm(currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            createSocialEventForm.Show();
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            VerifyForm verifyForm = new VerifyForm(currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            verifyForm.Show();
            this.Hide();
        }

        private void ButtonRefreshSocialEventList_Click(object sender, EventArgs e)
        {
            listBoxSocialEvents.DataSource = null;
            listBoxSocialEvents.DataSource = SocialEvent.SocialEventList;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}