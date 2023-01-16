using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

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

        /* Database manipulation methods */
        public User getUser(uint id)
        {
            string query = String.Format("SELECT * FROM users WHERE `ID` = {0};", id);
            return new User(executeQuery(query).First());
        }
        public void addUser(User user, string password)
        {
            MySqlDateTime serverDT = getServerDateTime();
            string query = String.Format(
                "INSERT INTO users " +
                "(`ID`, `Last Name`, `First Name`, `Middle Name`, `Login`, `Password`," +
                "`Registration DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",

                user.getId(), user.getLastName(), user.getFirstName(), user.getMiddleName(),
                user.getLogin(), password, serverDT, serverDT
                );
            executeQuery(query);
        }

        public void removeUser(uint id)
        {
            string query = String.Format("DELETE FROM users WHERE `ID` = {0};", id);
            executeQuery(query);
        }

        public MySqlDateTime getServerDateTime()
        {
            return (MySqlDateTime)executeQuery("SELECT NOW();").First().First();
        }

        public List<List<object>> executeQuery(string query)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<List<object>> result = new List<List<object>>();
            List<object> subres;

            while (reader.Read())
            {
                subres = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    subres.Add(reader.GetValue(i));
                result.Add(subres);
            }
            reader.Close();
            connection.Close();
            return result;
        }
    }
}
