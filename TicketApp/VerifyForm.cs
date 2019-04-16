﻿using Library.Logic;
using Library.Model;
using Library.PersistenceAdapter;
using Library.Persistency;
using Library.Verification;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class VerifyForm : Form
    {
        private ITargetPersistenceAdapter persistenceAdapter;
        private User currentUser = null;
        public VerifyForm(ITargetPersistenceAdapter persistenceAdapter, User currentUser)
        {
            this.persistenceAdapter = persistenceAdapter;
            this.currentUser = currentUser;

            InitializeComponent();
            InitializeInfo();
        }

        private void InitializeInfo()
        {
            var verificationMethods = Assembly.GetAssembly(typeof(IVerificationMethod)).GetTypes()
                .Where(myType => myType.GetInterfaces().Contains(typeof(IVerificationMethod)));

            foreach (Type verificationMethod in verificationMethods)
            {
                ComboVerificationMethod.Items.Add(Activator.CreateInstance(verificationMethod, true)).ToString();
            }
            if (ComboVerificationMethod.Items.Count > 0)
                ComboVerificationMethod.SelectedIndex = 0;
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            IVerificationMethod iVerificationMethod = (IVerificationMethod)ComboVerificationMethod.SelectedItem;
            bool result = iVerificationMethod.Verify();

            if(result == true)
            {
                if(currentUser.GetType() == typeof(Customer))
                {
                    DatabaseUnitOfWork uow = persistenceAdapter.GetUnitOfWork();
                    persistenceAdapter.Remove(uow.CustomerRepository, (Customer)currentUser);
                    Organizer upgradedCustomer = UserLogic.UpgradeCustomer((Customer)currentUser);
                    persistenceAdapter.Add(uow.OrganizerRepository, upgradedCustomer);
                    uow.Commit();

                    MessageBox.Show("Verification Success!");

                    LoginForm loginForm = new LoginForm(persistenceAdapter)
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = this.Location
                    };
                    this.Close();
                    loginForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Verification Failed.");
                SocialEventListForm socialEventListForm = new SocialEventListForm(persistenceAdapter, currentUser)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };
                this.Close();
                socialEventListForm.Show();
            }

            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            SocialEventListForm socialEventListForm = new SocialEventListForm(persistenceAdapter, currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            this.Close();
            socialEventListForm.Show();
        }
    }

}
