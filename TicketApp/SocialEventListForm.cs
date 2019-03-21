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
    public partial class SocialEventListForm : Form
    {
        User CurrentUser = null;
        public SocialEventListForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();

            listBoxSocialEvents.DataSource = SocialEvent.SocialEventList;

            if(user == null)
                this.Text = "Guest login";
            else
                this.Text = $"Logged in as: {user.Name}";
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

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            VerifyForm verifyForm = new VerifyForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            verifyForm.Show();
            this.Hide();
        }
    }
}