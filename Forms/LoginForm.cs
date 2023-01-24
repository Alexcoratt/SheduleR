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
        private MainForm mainForm;
        public LoginForm(Client client, MainForm mainForm)
        {
            InitializeComponent();
            LoginTextBox.Text = "alexsmir";
            PasswordTextBox.Text = "alexroot";
            this.client = client;
            this.mainForm = mainForm;
            StatusLabel.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            uint statusId;
            string statusName, statusDescription;
            client.LogIn(LoginTextBox.Text, PasswordTextBox.Text, out statusId, out statusName, out statusDescription);
            StatusLabel.Text = statusName;
            StatusLabel.Show();
            StatusDescriptionToolTip.SetToolTip(StatusLabel, statusDescription);
            if (statusId == 0)
            {
                Hide();
                mainForm.Visible = true;
                mainForm.ShowInTaskbar = true;
                mainForm.OnLogin();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
