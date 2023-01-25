using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using ScheduleR.Classes;
using ScheduleR.Classes.Queries;

using ScheduleR.Forms.EventManipulation;
using ScheduleR.Forms.UserManipulation;

namespace ScheduleR
{
    public partial class MainForm : Form
    {
        Client client;
        LoginForm loginForm;
        Echo events;
        Echo groups;
        Echo users;

        public MainForm()
        {
            InitializeComponent();
            client = new Client("192.168.0.106", "scheduler_schema", "appclient", "appclient");

            loginForm = new LoginForm(client, this);
        }

        protected override void OnLoad(EventArgs e)
        {
            SwitchTo(loginForm);
            base.OnLoad(e);
        }

        public void OnLogin()
        {
            RefreshEventGrid();
            RefreshUserGrid();
            ConsoleWriteLine("Authorized as id = " + client.userId.ToString());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log-out?", "Log-out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                client.LogOut();
                loginForm.ReInit();
                SwitchTo(loginForm);
                ReInit();
            }
        }

        public void SwitchTo(Form form)
        {
            Visible = false;
            ShowInTaskbar = false;
            form.Show();
        }

        public void ReInit()
        {
            Controls.Clear();
            InitializeComponent();
        }

        public void ConsoleWriteLine(object str)
        {
            string line;
            if (str is null)
                line = "\\null";
            else
                line = str.ToString();
            consoleTextBox.Text += line + "\n";
        }

        public void ConsoleWriteStatus(uint queryStatusId)
        {
            string statusName, statusDescription;
            client.getQueryStatusInfo(queryStatusId, out statusName, out statusDescription);
            ConsoleWriteLine(String.Format("Query status ID: {0}\nStatus name: {1}\nStatus description: {2}", queryStatusId, statusName, statusDescription));
        }


        // event methods
        public void RefreshEventGrid()
        {
            eventGridView.Rows.Clear();
            eventGridView.colDBNames = new Dictionary<string, string>();
            eventGridView.colDBNames.Add("headingCol", "Heading");
            eventGridView.colDBNames.Add("textCol", "Text");
            eventGridView.colDBNames.Add("beginDTCol", "Begin DateTime");
            eventGridView.colDBNames.Add("endDTCol", "End DateTime");
            eventGridView.colDBNames.Add("isPublicEventCol", "Public Event");

            events = client.getAvailableEvents();
            eventGridView.AddEcho(events);
        }


        private void eventGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (eventGridView.SelectedRows.Count > 0)
                SetMoreEventData(eventGridView.SelectedRows[0].Index);
        }

        private void SetMoreEventData(int rowIndex)
        {
            Dictionary<string, object> eventData = events.AsDict(rowIndex);
            Dictionary<string, object> eventOwnerData = client.getUserData((uint)eventData["Owner ID"]);

            eventHeadingLabel.Text = eventData["Heading"].ToString();
            eventIdLabel.Text = eventData["ID"].ToString();
            eventOwnerLabel.Text = eventOwnerData["Login"].ToString();
            eventCreationDTLabel.Text = eventData["Creation DateTime"].ToString();
            eventLastUpdateDTLabel.Text = eventData["Last Update DateTime"].ToString();
            eventTextBox.Text = eventData["Text"].ToString();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EventCreateForm(client, this).Show();
        }

        private void updateEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EventUpdateForm(client, this).Show();
        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventGridView.SelectedRows.Count > 0 && MessageBox.Show("Do you want to delete event?", "Delete event", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                uint queryStatus;
                Dictionary<string, object> eventData = events.AsDict(eventGridView.SelectedRows[0].Index);
                client.deleteEvent((uint)eventData["ID"], out queryStatus);
                ConsoleWriteStatus(queryStatus);
                RefreshEventGrid();
            }
        }

        private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshEventGrid();
        }
        // event methods <<<<

        // user methods

        public void RefreshUserGrid()
        {
            usersDataGridView.Rows.Clear();
            usersDataGridView.colDBNames = new Dictionary<string, string>();
            usersDataGridView.colDBNames.Add("userId", "ID");
            usersDataGridView.colDBNames.Add("login", "Login");
            usersDataGridView.colDBNames.Add("lastName", "Last Name");
            usersDataGridView.colDBNames.Add("firstName", "First Name");
            usersDataGridView.colDBNames.Add("accessLevel", "Access Level");

            users = client.getUsersData();
            usersDataGridView.AddEcho(users);
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserRegisterForm(client, this).Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                uint selectedId = (uint)usersDataGridView.SelectedRows[0].Cells[0].Value;
                uint queryStatusId;
                if (MessageBox.Show("Do you want to delete user?", "Delete user", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    client.userDelete(selectedId, out queryStatusId);
                    ConsoleWriteStatus(queryStatusId);
                    RefreshUserGrid();
                }
            }
            catch (NullReferenceException err) {
                ConsoleWriteLine(err);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshUserGrid();
        }
        // user methods <<<<
    }
}
