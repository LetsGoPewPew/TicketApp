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
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (CheckInputFields() == true)
            {
                if (UserLogic.Login(TextEmail.Text, TextPassword.Text))
                {
                    MessageBox.Show("Access allowed !");
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