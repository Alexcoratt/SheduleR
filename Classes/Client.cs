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
    public class Client
    {
        private MySqlConnection connection;
        private uint cust_id;
        private string cust_key;

        public Client(string server, string database, string username, string password)
        {
            connection = new MySqlConnection(string.Format(
                "server={0};user={1};database={2};password={3}",
                server, username, database, password
            ));
        }

        // <<<< Database reading methods >>>>
        public void OpenConnection()
        {
            if (connection.State.ToString() == "Closed")
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State.ToString() == "Open")
                connection.Close();
        }

        public string GetServerDateTime()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            MySqlParameter returnParam = new MySqlParameter("@DateTime", MySqlDbType.DateTime);
            returnParam.Direction = System.Data.ParameterDirection.ReturnValue;
            parameters.Add(returnParam);
            ExecuteFunction("get_datetime", parameters);
            return ((System.DateTime)returnParam.Value).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string LogIn(string login, string pwd)
        {
            MySqlParameter varKey = new MySqlParameter("@key", MySqlDbType.VarChar);
            varKey.Direction = System.Data.ParameterDirection.ReturnValue;

            MySqlParameter varLogin = new MySqlParameter("@login", MySqlDbType.VarChar);
            varLogin.Value = login;
            MySqlParameter varPwd = new MySqlParameter("@pwd", MySqlDbType.VarChar);
            varPwd.Value = pwd;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(varLogin);
            parameters.Add(varPwd);
            parameters.Add(varKey);
            ExecuteFunction("log_in", parameters);
            return varKey.Value.ToString();
        }

        public List<Dictionary<string, object>> ReadQuery(string query)
        {
            OpenConnection();
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
            CloseConnection();
            return result;
        }

        public List<Dictionary<string, object>>
            ReadProcedure(string procedureName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres;

            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                subres = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    subres.Add(reader.GetName(i), reader.GetValue(i));
                result.Add(subres);
            }
            reader.Close();
            CloseConnection();

            return result;
        }

        public void ExecuteFunction(string functionName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(functionName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            OpenConnection();
            command.ExecuteScalar();
            CloseConnection();
        }

        // >>>> Database reading methods <<<<
        public static string EchoToString(List<Dictionary<string, object>> echo)
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

        public static string DictToString(Dictionary<string, object> dict)
        {
            StringBuilder result = new StringBuilder();
            foreach (string key in dict.Keys)
                result.Append(dict[key].ToString()).
                    Append("\t");
            return result.ToString();
        }

        public static string JoinToString(string separator, object[] arr)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arr.Length - 1; i++)
                result.Append(arr[i].ToString()).Append(separator);
            result.Append(arr[arr.Length - 1].ToString());
            return result.ToString();
        }
    }
}
