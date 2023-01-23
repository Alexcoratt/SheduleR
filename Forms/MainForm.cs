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
        public MainForm()
        {
            InitializeComponent();
            Client client = new Client("192.168.0.106", "scheduler_schema", "appclient", "appclient");

            LoginForm loginForm = new LoginForm();
            loginForm.SetClient(client);
            loginForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);
        }
    }
}
