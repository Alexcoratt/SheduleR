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
            Echo echo = new Echo();

            MySqlParameter testPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            testPar.Value = 4;
            echo.Set(client.ReadProcedure("get_available_events", testPar));
            Console.WriteLine(echo.ToString());
        }
    }
}
