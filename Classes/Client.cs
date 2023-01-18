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
        public void openConnection()
        {
            if (connection.State.ToString() == "Closed")
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State.ToString() == "Open")
                connection.Close();
        }

        public string getServerDateTime()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter returnParam = new MySqlParameter("@DateTime", MySqlDbType.DateTime);
            returnParam.Direction = System.Data.ParameterDirection.ReturnValue;
            parameters.Add(returnParam);
            executeFunction("get_datetime", parameters);
            return ((System.DateTime)returnParam.Value).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Dictionary<string, object> getUserData(uint userId)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter userIdParam = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdParam.Direction = System.Data.ParameterDirection.Input;
            userIdParam.Value = userId;
            parameters.Add(userIdParam);
            return readProcedure("get_user_data", parameters).First();
        }

        public byte getUserAccessLevel(uint userId)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter uId = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            uId.Value = userId;
            parameters.Add(uId);

            MySqlParameter access = new MySqlParameter("@access", MySqlDbType.UByte);
            access.Direction = System.Data.ParameterDirection.ReturnValue;
            parameters.Add(access);

            executeFunction("get_user_access_level", parameters);
            return (byte)access.Value;
        }

        public Dictionary<string, object> getGroupData(uint groupId)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter gId = new MySqlParameter("@group_id", MySqlDbType.UInt32);
            gId.Direction = System.Data.ParameterDirection.Input;
            gId.Value = groupId;
            parameters.Add(gId);
            return readProcedure("get_group_data", parameters).First();
        }

        public List<Dictionary<string, object>> getUserGroupsData(uint userId)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter user = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            user.Direction = System.Data.ParameterDirection.Input;
            user.Value = userId;
            parameters.Add(user);
            return readProcedure("get_user_groups_data", parameters);
        }

        public uint getFreeId(string tableName)
        {
            IEnumerator<Dictionary<string, object>> e = readQuery(String.Format(
                "SELECT `ID` FROM {0} ORDER BY `ID`;", tableName
                )).GetEnumerator();

            uint lastId = 0;
            while (e.MoveNext() && (uint)e.Current["ID"] - lastId <= 1)
            {
                lastId = (uint)e.Current["ID"];
            }
            return lastId + 1;
        }

        public List<Dictionary<string, object>> readQuery(string query)
        {
            openConnection();
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
            closeConnection();
            return result;
        }

        public List<Dictionary<string, object>>
            readProcedure(string procedureName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres;

            openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                subres = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    subres.Add(reader.GetName(i), reader.GetValue(i));
                result.Add(subres);
            }
            reader.Close();
            closeConnection();

            return result;
        }

        public void executeFunction(string functionName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(functionName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            openConnection();
            command.ExecuteScalar();
            closeConnection();
        }

        // >>>> Database reading methods <<<<
        public static string echoToString(List<Dictionary<string, object>> echo)
        {
            StringBuilder result = new StringBuilder();
            foreach (Dictionary<string, object> line in echo)
            {
                foreach (string key in line.Keys)
                    result.Append(line[key].ToString()).
                        Append("\t");
                result.AppendLine();
            }
            return result.ToString();
        }

        public static string dictToString(Dictionary<string, object> dict)
        {
            StringBuilder result = new StringBuilder();
            foreach (string key in dict.Keys)
                result.Append(dict[key].ToString()).
                    Append("\t");
            return result.ToString();
        }

        public static string joinToString(string separator, object[] arr)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arr.Length - 1; i++)
                result.Append(arr[i].ToString()).Append(separator);
            result.Append(arr[arr.Length - 1].ToString());
            return result.ToString();
        }
    }
}
