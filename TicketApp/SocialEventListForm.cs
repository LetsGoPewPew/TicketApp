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
        public SocialEventListForm(Point location)
        {
            InitializeComponent();
            this.Location = location;

            listBoxSocialEvents.DataSource = SocialEvent.SocialEventList;
        }
        private void ButtonBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicket = new BuyTicketForm((SocialEvent)listBoxSocialEvents.SelectedItem, this.Location)
            {
                StartPosition = FormStartPosition.Manual
            };
            buyTicket.Show();
        }
    }
}
