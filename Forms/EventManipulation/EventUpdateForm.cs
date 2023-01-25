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

namespace ScheduleR.Forms.EventManipulation
{
    public partial class EventUpdateForm : Form
    {
        Client client;
        MainForm mainForm;
        Echo events;

        public EventUpdateForm(Client client, MainForm mainForm)
        {
            InitializeComponent();
            this.client = client;
            this.mainForm = mainForm;
        }

        private void EventUpdateForm_Load(object sender, EventArgs e)
        {
            SetEvents(client.getAvailableEvents());
            RefreshEventGrid();
        }

        public void RefreshEventGrid()
        {
            eventGridView.Rows.Clear();
            eventGridView.colDBNames = new Dictionary<string, string>();
            eventGridView.colDBNames.Add("eventId", "ID");
            eventGridView.colDBNames.Add("eventHeading", "Heading");

            SetEvents(client.getAvailableEvents());
            eventGridView.AddEcho(events);
        }

        public void SetEvents(Echo echo)
        {
            events = echo;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            uint queryStatusId;
            uint selectedId;
            try
            {
                selectedId = (uint)eventGridView.SelectedRows[0].Cells[0].Value;
                client.updateEvent(
                    selectedId, eventHeadingTextBox.Text,
                    eventTextTextBox.Text, beginDateTimePicker.Value, endDateTimePicker.Value,
                    out queryStatusId
                );

                mainForm.ConsoleWriteStatus(queryStatusId);
                RefreshEventGrid();
                mainForm.RefreshEventGrid();
            }
            catch (NullReferenceException ignored) { }
        }

        private void eventGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index;
            if (eventGridView.SelectedRows.Count > 0)
            {
                index = eventGridView.SelectedRows[0].Index;
                SetTextBoxes(index);
            }
        }

        private void SetTextBoxes(int rowIndex)
        {
            Dictionary<string, object> eventData = events.AsDict(rowIndex);

            eventHeadingTextBox.Text = eventData["Heading"].ToString();
            eventTextTextBox.Text = eventData["Text"].ToString();
            beginDateTimePicker.Value = (DateTime)eventData["Begin DateTime"];
            endDateTimePicker.Value = (DateTime)eventData["End DateTime"];
        }
    }
}
