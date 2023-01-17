using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using MySql.Data.Types;
using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes
{
    class Client
    {
        private MySqlConnection connection;

        public Client(string server, string database, string username, string password)
        {
            connection = new MySqlConnection(string.Format(
                "server={0};user={1};database={2};password={3}",
                server, username, database, password
                ));
        }

        // <<<< Database manipulation methods >>>>
        // <<<< User management

        public void addUser(User user, string password)
        {
            MySqlDateTime serverDT = getServerDateTime();
            string query = String.Format(
                "INSERT INTO users " +
                "(`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`, " +
                "`Registration DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",

                user.getId(), user.getLogin(), password, 
                user.getLastName(), user.getFirstName(), user.getMiddleName(), serverDT, serverDT
                );
            executeQuery(query);
        }

        public void removeUser(User user)
        {
            string query = String.Format("DELETE FROM users WHERE `ID` = {0};", user.getId());
            executeQuery(query);
        }
        // >>>>

        // <<<< Group management methods
        // >>>>

        public MySqlDateTime getServerDateTime()
        {
            return (MySqlDateTime)executeQuery("SELECT NOW();").First().First();
        }

        public List<Dictionary<string, object>> executeQuery(string query)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres;

            while (reader.Read())
            {
                subres = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    subres.Add(reader.GetName(i), reader.GetValue(i));
                result.Add(subres);
            }
            reader.Close();
            connection.Close();
            return result;
        }
        // >>>> Database manipulation methods <<<<
    }
}
