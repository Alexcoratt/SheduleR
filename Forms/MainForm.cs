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

        public void FillEventTable(List<Dictionary<string, object>> echo)
        {
            string[] keysToShow = new string[] {
                "Heading",
                "Text",
                "Begin DateTime",
                "End DateTime"
            };

            Console.WriteLine(echo.Count);
            if (echo.Count == 0)
            {
                eventTable.RowCount = 1;
                eventTable.ColumnCount = 1;
                addPanelLabel(eventTable, 0, 0, "No available events");
            }
            else
            {
                echo.Add(echo.First());
                int height = echo.Count + 1;
                int width = keysToShow.Length;
                eventTable.RowCount = height;

                int i = 1, j;

                for (j = 0; j < width; j++)
                {
                    addPanelLabel(eventTable, 0, j, keysToShow[j]);
                }
                
                foreach (Dictionary<string, object> line in echo)
                {
                    for (j = 0; j < width; j++)
                        addPanelLabel(eventTable, i, j, line[keysToShow[j]].ToString());
                    i++;
                }
            }
        }

        public void addPanelLabel(TableLayoutPanel panel, int i, int j, string labelText)
        {
            Label label = new Label();
            label.Text = labelText;
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(label, j, i);
        }

        public void OnLogin()
        {
            FillEventTable(client.getAvailableEvents());
        }
    }
}
