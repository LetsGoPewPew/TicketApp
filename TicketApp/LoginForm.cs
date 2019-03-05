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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FillTestData();
        }

        private void FillTestData()
        {
            Customer customer1 = new Customer("1", "1", "1");
            Customer customer2 = new Customer("2", "2", "2");

            SocialEvent socialEvent1 = new SocialEvent(5, "Art", "Kristine og Ramona synger bæ bæ lille lam");
            SocialEvent socialEvent2 = new SocialEvent(7, "Sports", "Stian og Jørgen Sjonglerer med datamus");
            SocialEvent socialEvent3 = new SocialEvent(9, "TalentShow", "Juan kjører solo dukkeshow");

            Ticket ticket1 = new Ticket(socialEvent1);
            Ticket ticket2 = new Ticket(socialEvent1);
            Ticket ticket3 = new Ticket(socialEvent1);
            Ticket ticket4 = new Ticket(socialEvent1);
            Ticket ticket5 = new Ticket(socialEvent2);
            Ticket ticket6 = new Ticket(socialEvent2);
            Ticket ticket7 = new Ticket(socialEvent2);
            Ticket ticket8 = new Ticket(socialEvent3);

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (CheckInputFields() == true)
            {
                if (UserLogic.Login(TextEmail.Text, TextPassword.Text))
                {
                    //MessageBox.Show("Access allowed !");
                    SocialEventListForm socialEventListForm = new SocialEventListForm();
                    socialEventListForm.Show();
                }
                else
                {
                    MessageBox.Show("Access denied !");
                }
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (CheckInputFields() == true)
            {
                if (UserLogic.EmailInUse(TextEmail.Text) == true)
                {
                    MessageBox.Show("Email already in use sir");
                    return;
                }
                User.UserList.Add(new Customer("", TextEmail.Text, TextPassword.Text));
                MessageBox.Show("Successfully registered ! :D");
            }
        }
        private bool CheckInputFields()
        {
            if (String.IsNullOrEmpty(TextEmail.Text) ||
                String.IsNullOrEmpty(TextPassword.Text))
            {
                MessageBox.Show("User input pls");
                return false;
            }
            return true;
        }
    }
}