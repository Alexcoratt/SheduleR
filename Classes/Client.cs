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
        public Dictionary<string, byte> dbConnectionTypes;

        public Client(string server, string database, string username, string password)
        {
            connection = new MySqlConnection(string.Format(
                "server={0};user={1};database={2};password={3}",
                server, username, database, password
                ));
            dbConnectionTypes = new Dictionary<string, byte>();
            dbConnectionTypes.Add("user-group", 0);
            dbConnectionTypes.Add("event-group", 1);
            dbConnectionTypes.Add("note-group", 2);
        }

        // <<<< Database reading methods >>>>

        public string getServerDateTime()
        {
            return ((DateTime)executeQuery("SELECT NOW() as 'Current Time';").
                First()["Current Time"]).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Dictionary<string, object> getUserData(uint userId)
        {
            Dictionary<string, object> data = executeQuery(String.Format(
                "SELECT * FROM users WHERE `ID` = {0};", userId)).First();
            data.Remove("Password");
            return data;
        }

        public byte getUserAccessLevel(uint userId)
        {
            return (byte)executeQuery(String.Format(
                "SELECT MIN(`Access Level`) as 'Access Level' " +
                "FROM scheduler_schema.groups " +
                "INNER JOIN (connections) " +
                "ON (connections.`Second ID` = `ID`) " +
                "WHERE connections.`First ID` = {0} AND " +
                "`Connection Type` = " + dbConnectionTypes["user-group"] + ";",
                userId)).First()["Access Level"];
        }

        public Dictionary<string, object> getGroupData(uint groupId)
        {
            return executeQuery(String.Format(
                "SELECT * FROM scheduler_schema.groups " +
                "WHERE `ID` = {0};", groupId
                )).First();
        }

        public List<uint> getGroups(uint userId)
        {
            List<uint> result = new List<uint>();
            List<Dictionary<string, object>> serverAnswer = executeQuery(String.Format(
                "SELECT `Second ID` as 'Group ID'" +
                "FROM connections " +
                "WHERE `First ID` = {0} AND " +
                "`Connection Type` = " + dbConnectionTypes["user-group"] + ";",
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
            if (connection.State.ToString() == "Closed")
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
