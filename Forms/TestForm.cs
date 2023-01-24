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
using MySql.Data.MySqlClient;

namespace ScheduleR.Forms
{
    public partial class TestForm : Form
    {
        Client client;
        public TestForm()
        {
            InitializeComponent();

            client = new Client("192.168.0.106", "scheduler_schema", "appclient", "appclient");

            MySqlParameter testPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            testPar.Value = 0;
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(testPar);

            Echo echo = client.ReadProcedure("get_available_events", parameters);
            Console.WriteLine(echo.ToString(true));

            Dictionary<string, object> test = new Dictionary<string, object>();
            test.Add("Name", "Name");
            test.Add("Description", "Description");
            test.Add("Begin DateTime", "Begin DateTimesdagsfjsfdgfjfhsdfh");
            test.Add("End DateTime", "End DateTimedfgfdshjhfgjdg");

            Dictionary<string, string> cdn = new Dictionary<string, string>();
            cdn.Add("headingCol", "Heading");
            cdn.Add("textCol", "Text");
            cdn.Add("beginDTCol", "Begin DateTime");
            cdn.Add("endDTCol", "End DateTime");

            myDataGridView1.colDBNames = cdn;
            myDataGridView1.AddEcho(echo);
            myDataGridView1.AddEcho(echo);
            myDataGridView1.AddEcho(echo);
        }
    }
}
