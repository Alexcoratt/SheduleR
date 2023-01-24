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

namespace ScheduleR
{
    public partial class MainForm : Form
    {
        Client client;

        public MainForm()
        {
            InitializeComponent();
            client = new Client("192.168.0.106", "scheduler_schema", "appclient", "appclient");

            LoginForm loginForm = new LoginForm(client, this);
            loginForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);
        }

        public void OnLogin()
        {
            eventGridView.colDBNames = new Dictionary<string, string>();
            eventGridView.colDBNames.Add("headingCol", "Heading");
            eventGridView.colDBNames.Add("textCol", "Text");
            eventGridView.colDBNames.Add("beginDTCol", "Begin DateTime");
            eventGridView.colDBNames.Add("endDTCol", "End DateTime");
            eventGridView.colDBNames.Add("isPublicEventCol", "Public");

            eventGridView.AddEcho(client.getAvailableEvents());
        }
    }
}
