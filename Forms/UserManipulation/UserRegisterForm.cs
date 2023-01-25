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

namespace ScheduleR.Forms.UserManipulation
{
    public partial class UserRegisterForm : Form
    {
        Client client;
        MainForm mainForm;
        public UserRegisterForm(Client client, MainForm mainForm)
        {
            InitializeComponent();
            this.client = client;
            this.mainForm = mainForm;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            userRegister(lastNameTextBox.Text, firstNameTextBox.Text, middleNameTextBox.Text);
        }

        public void userRegister(string lName, string fName, string mName)
        {
            uint userId, queryStatusId;
            string pwd;
            client.userRegister(lName, fName, mName, out userId, out pwd, out queryStatusId);
            if (queryStatusId == 0)
            {
                string login = client.getUserData(userId)["Login"].ToString();
                MessageBox.Show(String.Format(
                    "Your temporary login and password.\nLogin: {0}\nPassword: {1}", login, pwd
                    ), "Personal data", MessageBoxButtons.OK);
                mainForm.RefreshUserGrid();
            }
            mainForm.ConsoleWriteStatus(queryStatusId);
        }
    }
}
