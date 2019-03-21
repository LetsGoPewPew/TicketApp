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