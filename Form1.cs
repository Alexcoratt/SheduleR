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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Client client = new Client("localhost", "scheduler_schema", "root", "admin");

            Query cu = new CreateUser(client, 0);
            Query cug = new CreateUserGroup(client, 1);
            Query cc = new CreateConnection(client, 0);
            //cu.execute("O", "Khva Sen", "");
            cug.execute("group2", 2, 2);
        }
    }
}
