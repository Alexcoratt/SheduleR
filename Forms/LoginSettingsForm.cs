using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleR.Forms
{
    public partial class LoginSettingsForm : Form
    {
        LoginForm loginForm;
        public LoginSettingsForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            fillSettings();
        }

        private void fillSettings()
        {
            hostNameTextBox.Text = loginForm.connSettings["hostname"];
            dbNameTextBox.Text = loginForm.connSettings["dbName"];
            userNameTextBox.Text = loginForm.connSettings["username"];
            pwdTextBox.Text = loginForm.connSettings["pwd"];
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            loginForm.connSettings["hostname"] = hostNameTextBox.Text;
            loginForm.connSettings["dbName"] = dbNameTextBox.Text;
            loginForm.connSettings["username"] = userNameTextBox.Text;
            loginForm.connSettings["pwd"] = pwdTextBox.Text;
            this.Close();
        }
    }
}
