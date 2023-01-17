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

            User alex = new User(client, 0);
            Query gud = new GetUserGroupsData(client, alex);
            Console.WriteLine(gud.executeToString(0));

            Query gfid = new GetFreeId(client, alex);
            Console.WriteLine(gfid.executeToString("users"));
            Console.WriteLine(gfid.nsExecute("users"));

            Query gual = new GetUserAccessLevel(client, alex);
            Console.WriteLine(gual.nsExecute(0));
            Console.WriteLine(gual.nsExecute(1));

            Query gsdt = new GetServerDateTime(client, alex);
            Console.WriteLine(gsdt.nsExecute());

            User testUser = new User(client, 1);
            Console.WriteLine(testUser);
            AddUser au = new AddUser(client, testUser);
            au.execute("O", "Khva Sen", "", 1);
        }
    }
}
