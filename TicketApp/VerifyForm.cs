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
using Library.Verification;

namespace TicketApp
{
    public partial class VerifyForm : Form
    {
        public VerifyForm()
        {
            InitializeComponent();
            InitializeInfo();
        }

        private void InitializeInfo()
        {
            var verificationMethods = Assembly.GetAssembly(typeof(IVerification)).GetTypes()
                .Where(myType => myType.GetInterfaces().Contains(typeof(IVerification)));

            foreach (Type verificationMethod in verificationMethods)
            {
                ComboVerificationMethod.Items.Add(Activator.CreateInstance(verificationMethod, true)).ToString();
            }
            if (ComboVerificationMethod.Items.Count > 0)
                ComboVerificationMethod.SelectedIndex = 0;
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            IVerification iVerificationMethod = (IVerification)ComboVerificationMethod.SelectedItem;
            bool result = iVerificationMethod.Verify();

            if(result == true)
            {
                MessageBox.Show("Verification Success!");
            }
            else
            {
                MessageBox.Show("Verification Failed.");
            }

            this.Close();
        }
    }

}
