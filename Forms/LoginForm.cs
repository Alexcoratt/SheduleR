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
        }

        public void SetClient(Client client)
        {
            this.client = client;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string accessKey = client.LogIn(LoginTextBox.Text, PasswordTextBox.Text);
            Console.WriteLine(accessKey);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
