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

namespace ScheduleR.Forms
{
    public partial class LoginForm : Form
    {
        private Client client;

        public Dictionary<string, string> connSettings;
        public LoginForm()
        {
            InitializeComponent();
            LoginTextBox.Text = "alexsmir";
            PasswordTextBox.Text = "alexroot";
            StatusLabel.Hide();

            connSettings = new Dictionary<string, string>();
            connSettings.Add("hostname", "192.168.0.103");
            connSettings.Add("dbName", "scheduler_schema");
            connSettings.Add("username", "sch_app_user");
            connSettings.Add("pwd", "schappuser");
        }

        public void SetClient()
        {
            client = new Client(connSettings["hostname"], connSettings["dbName"], connSettings["username"], connSettings["pwd"]);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            uint statusId;
            string statusName, statusDescription;

            SetClient();

            try
            {
                client.LogIn(LoginTextBox.Text, PasswordTextBox.Text, out statusId, out statusName, out statusDescription);
            }
            catch (MySql.Data.MySqlClient.MySqlException err)
            {
                statusId = 1;
                statusName = "NO CONNECTION TO DATABASE";
                statusDescription = "Wrong connection settings";
                Console.WriteLine(err);
            }

            StatusLabel.Text = statusName;
            StatusLabel.Show();
            StatusDescriptionToolTip.SetToolTip(StatusLabel, statusDescription);

            if (statusId == 0)
            {
                MainForm mainForm = new MainForm(client, this);
                mainForm.Show();
                mainForm.OnLogin();
                Hide();
                ReInit();
            }
        }

        public void ReInit()
        {
            Controls.Clear();
            InitializeComponent();
            StatusLabel.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginSettingsForm(this).Show();
        }
    }
}
