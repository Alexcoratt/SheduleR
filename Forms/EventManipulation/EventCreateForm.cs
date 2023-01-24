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
    public partial class EventCreateForm : Form
    {
        Client client;
        MainForm mainForm;
        public EventCreateForm(Client client, MainForm mainForm)
        {
            InitializeComponent();
            this.client = client;
            this.mainForm = mainForm;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            uint eventId, queryStatusId;
            client.createEvent(
                eventHeadingTextBox.Text, eventTextTextBox.Text,
                beginDateTimePicker.Value, endDateTimePicker.Value,
                out eventId, out queryStatusId
            );
            Console.WriteLine(eventId);
            Console.WriteLine(queryStatusId);
            mainForm.RefreshEventGrid();
        }
    }
}
