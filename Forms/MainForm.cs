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

namespace ScheduleR
{
    public partial class MainForm : Form
    {
        Client client;
        LoginForm loginForm;
        Echo events;

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
            ConsoleWriteLine("Authorized as id = " + client.userId.ToString());
        }

        public void RefreshEventGrid()
        {
            eventGridView.Rows.Clear();
            eventGridView.colDBNames = new Dictionary<string, string>();
            eventGridView.colDBNames.Add("headingCol", "Heading");
            eventGridView.colDBNames.Add("textCol", "Text");
            eventGridView.colDBNames.Add("beginDTCol", "Begin DateTime");
            eventGridView.colDBNames.Add("endDTCol", "End DateTime");
            eventGridView.colDBNames.Add("isPublicEventCol", "Public Event");

            SetEvents(client.getAvailableEvents());
            eventGridView.AddEcho(events);
        }

        public void SetEvents(Echo echo)
        {
            events = echo;
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

        private void eventGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (eventGridView.SelectedRows.Count > 0)
                SetMoreData(eventGridView.SelectedRows[0].Index);
        }

        private void SetMoreData(int rowIndex)
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

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint queryStatus = 1;
            if (eventGridView.SelectedRows.Count > 0) {
                Dictionary<string, object> eventData = events.AsDict(eventGridView.SelectedRows[0].Index);
                client.deleteEvent((uint)eventData["ID"], out queryStatus);
            }
            ConsoleWriteStatus(queryStatus);
            RefreshEventGrid();
        }

        private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshEventGrid();
        }
    }
}
