using Library.Logic;
using Library.Model;
using Library.PersistenceAdapter;
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
    public partial class RegisterForm : Form
    {
        private ITargetPersistenceAdapter persistenceAdapter;
        public RegisterForm(ITargetPersistenceAdapter persistenceAdapter)
        {
            InitializeComponent();
            this.persistenceAdapter = persistenceAdapter;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (CheckInputFields() == false)
            {
                MessageBox.Show("You must fill in username/password");
                return;
            }
            else
            {
                if (UserLogic.EmailInUse(TextEmail.Text))
                {
                    MessageBox.Show($"Email: {TextEmail.Text} is already in use");
                }
                else
                {
                    Customer newCustomer = new Customer(TextName.Text, TextEmail.Text, TextPassword.Text);
                    persistenceAdapter.Add(persistenceAdapter.GetUnitOfWork().CustomerRepository, newCustomer);
                    persistenceAdapter.GetUnitOfWork().Commit();

                    MessageBox.Show($"Welcome to Ticketapp {newCustomer.Name}");

                    LoginForm loginForm = new LoginForm(persistenceAdapter)
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = this.Location
                    };
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private bool CheckInputFields()
        {
            if (String.IsNullOrEmpty(TextEmail.Text) ||
                String.IsNullOrEmpty(TextPassword.Text) ||
                String.IsNullOrEmpty(TextName.Text))
            {
                MessageBox.Show("User input pls");
                return false;
            }
            return true;
        }
    }
}
