using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScheduleR.Classes;

namespace ScheduleR
{
    public partial class LoginForm : Form
    {
        private Client client;
        public LoginForm()
        {
            InitializeComponent();
            LoginTextBox.Text = "alexsmir";
            PasswordTextBox.Text = "alexroot";
        }

        public void SetClient(Client client)
        {
            this.client = client;
            StatusLabel.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string statusName, statusDescription;
            client.LogIn(LoginTextBox.Text, PasswordTextBox.Text, out statusName, out statusDescription);
            StatusLabel.Text = statusName;
            StatusLabel.Show();
            StatusDescriptionToolTip.SetToolTip(StatusLabel, statusDescription);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
