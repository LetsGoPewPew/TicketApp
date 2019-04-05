using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Logic;
using Library.Model;
using Library.Verification;

namespace TicketApp
{
    public partial class VerifyForm : Form
    {
        User CurrentUser = null;
        public VerifyForm(User currentUser)
        {
            CurrentUser = currentUser;

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
                if(CurrentUser.GetType() == typeof(Customer))
                {
                    UserLogic.UpgradeCustomer((Customer)CurrentUser);
                    MessageBox.Show("Verification Success!");

                    LoginForm loginForm = new LoginForm()
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
                SocialEventListForm socialEventListForm = new SocialEventListForm(CurrentUser)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };
                this.Close();
                socialEventListForm.Show();
            }

            this.Close();
        }
    }

}
