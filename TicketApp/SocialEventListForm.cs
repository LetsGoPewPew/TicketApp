﻿using System;
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
            {
                this.Text = $"Logged in as: {user.Name}";
                if(user.GetType() == typeof(Organizer))
                {
                    ButtonCreateSocialEvent.Visible = true;
                    this.Text += " (Organizer)";
                }
                else
                {
                    this.Text += " (Customer)";
                }

                if(user.GetType() == typeof(Customer))
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
            this.Close();
        }

        private void ButtonCreateSocialEvent_Click(object sender, EventArgs e)
        {
            CreateSocialEventForm createSocialEventForm = new CreateSocialEventForm(CurrentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            createSocialEventForm.Show();
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            VerifyForm verifyForm = new VerifyForm(CurrentUser)
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