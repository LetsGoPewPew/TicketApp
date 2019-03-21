using Library.Logic;
using Library.Model;
using System;
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
            Organizer organizer1 = new Organizer("3", "3", "3");

            SocialEvent socialEvent1 = new SocialEvent(5, 133, "Art", "Kristine og Ramona synger bæ bæ lille lam");
            SocialEvent socialEvent2 = new SocialEvent(7, 5643, "Sports", "Stian og Jørgen Sjonglerer med datamus");
            SocialEvent socialEvent3 = new SocialEvent(9, 2312, "TalentShow", "Juan kjører solo dukkeshow");
            SocialEvent socialEvent4 = new SocialEvent(5, 436, "Sports", "Test event 1 (sports)");
            SocialEvent socialEvent5 = new SocialEvent(7, 12, "Sports", "Test event 2 (sports)");
            SocialEvent socialEvent6 = new SocialEvent(9, 432, "Concert", "Test event 3 (concert)");
            SocialEvent socialEvent7 = new SocialEvent(5, 768, "Concert", "Test event 4 (concert)");
            SocialEvent socialEvent8 = new SocialEvent(7, 654, "Art", "Test event 5 (art)");
            SocialEvent socialEvent9 = new SocialEvent(9, 564, "TalentShow", "Test event 6 (talentShow)");

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
            if (CheckInputFields() == false)
            {
                MessageBox.Show("You must fill in username/password");
                return;
            }
            string email = TextEmail.Text;
            string password = TextPassword.Text;

            if (UserLogic.Login(email, password))
            {
                GoTosocialEventListForm(UserLogic.GetUserByEmail(email));
            }
            else
            {
                MessageBox.Show("Access denied !");
            }
        }

        private void ButtonNoLoggin_Click(object sender, EventArgs e)
        {
            GoTosocialEventListForm(null);
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

        private void GoTosocialEventListForm(User currentUser)
        {
            SocialEventListForm socialEventListForm = new SocialEventListForm(currentUser)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            socialEventListForm.Show();
            this.Hide();
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