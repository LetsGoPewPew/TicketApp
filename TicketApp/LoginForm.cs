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

            foreach(string u in Enum.GetNames(typeof(User)))
            {
                ComboUser.Items.Add(u);
            }
            ComboUser.SelectedIndex = 0;
        }

        private void ComboUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}