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

        // <<<< Database reading methods >>>>

        public string getServerDateTime()
        {
            return ((DateTime)executeQuery("SELECT NOW() as 'Current Time';").
                First()["Current Time"]).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Dictionary<string, object> getUserData(uint userId)
        {
            return executeQuery(String.Format(
                "SELECT * FROM users WHERE `ID` = {0};"
                , userId)).First();
        }

        public byte getUserAccessLevel(uint userId)
        {
            return (byte)executeQuery(String.Format(
                "SELECT MAX(`Access Level`) as 'Access Level'" +
                "FROM user_groups " +
                "INNER JOIN (user_group_connections) " +
                "ON (user_group_connections.`Group ID` = user_groups.`ID`) " +
                "WHERE user_group_connections.`User ID` = {0};",
                userId)).First()["Access Level"];
        }

        public Dictionary<string, object> getUserGroupData(uint groupId)
        {
            return executeQuery(String.Format(
                "SELECT * FROM user_groups " +
                "WHERE `ID` = {0};", groupId
                )).First();
        }

        public List<uint> getUserConnections(uint userId)
        {
            List<uint> result = new List<uint>();
            List<Dictionary<string, object>> serverAnswer = executeQuery(String.Format(
                "SELECT `Group ID` " +
                "FROM user_group_connections " +
                "WHERE `User ID` = {0};",
                userId));
            foreach (Dictionary<string, object> line in serverAnswer)
                result.Add((uint)line["Group ID"]);
            return result;
        }

        public uint getFreeId(string tableName)
        {
            IEnumerator<Dictionary<string, object>> e = executeQuery(String.Format(
                "SELECT `ID` FROM {0} ORDER BY `ID`;", tableName
                )).GetEnumerator();

            uint lastId = 0;
            while (e.MoveNext() && (uint)e.Current["ID"] - lastId <= 1)
            {
                lastId = (uint)e.Current["ID"];
            }
            return lastId + 1;
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
        // >>>> Database reading methods <<<<
    }
}
