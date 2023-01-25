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
        public uint userId;
        private string userKey;

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
            ExecuteProcedure("get_datetime", parameters);
            return ((System.DateTime)returnParam.Value).ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void LogIn(string login, string pwd, out uint statusId, out string statusName, out string statusDescription)
        {
            MySqlParameter varLogin = new MySqlParameter("@login", MySqlDbType.VarChar);
            varLogin.Value = login;
            MySqlParameter varPwd = new MySqlParameter("@pwd", MySqlDbType.VarChar);
            varPwd.Value = pwd;

            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.VarChar);
            userIdPar.Direction = System.Data.ParameterDirection.Output;
            MySqlParameter userKey = new MySqlParameter("@user_key", MySqlDbType.VarChar);
            userKey.Direction = System.Data.ParameterDirection.Output;
            MySqlParameter qStatus = new MySqlParameter("@query_status", MySqlDbType.VarChar);
            qStatus.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(varLogin);
            parameters.Add(varPwd);
            parameters.Add(userIdPar);
            parameters.Add(userKey);
            parameters.Add(qStatus);

            ExecuteProcedure("log_in", parameters);

            uint parsedUserId, parsedQueryStatusId;
            uint.TryParse(userIdPar.Value.ToString(), out parsedUserId);
            uint.TryParse(qStatus.Value.ToString(), out parsedQueryStatusId);

            getQueryStatusInfo(parsedQueryStatusId, out statusName, out statusDescription);

            statusId = parsedQueryStatusId;

            if (parsedQueryStatusId == 0) {
                userId = parsedUserId;
                this.userKey = userKey.Value.ToString();
            }
        }

        public void LogOut()
        {
            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdPar.Value = userId;
            MySqlParameter queryStatus = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatus.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(userIdPar);
            parameters.Add(queryStatus);

            ExecuteProcedure("log_out", parameters);

            userKey = null;
        }

        public Dictionary<string, object> getUserData(uint userId)
        {
            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdPar.Value = userId;

            return ReadProcedure("get_user_data", userIdPar).AsDict(0);
        }

        public void getQueryStatusInfo(uint queryId, out string statusName, out string statusDescription)
        {
            MySqlParameter queryIdPar = new MySqlParameter("@status_id", MySqlDbType.UInt32);
            queryIdPar.Value = queryId;

            MySqlParameter statusNamePar = new MySqlParameter("@status_name", MySqlDbType.VarChar);
            statusNamePar.Direction = System.Data.ParameterDirection.Output;

            MySqlParameter statusDescriptionPar = new MySqlParameter("@status_description", MySqlDbType.VarChar);
            statusDescriptionPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(queryIdPar);
            parameters.Add(statusNamePar);
            parameters.Add(statusDescriptionPar);
            ExecuteProcedure("get_query_status_info", parameters);
            statusName = statusNamePar.Value.ToString();
            statusDescription = statusDescriptionPar.Value.ToString();
        }

        // <<<< event methods
        public void createEvent(string heading, string text, DateTime begDT, DateTime endDT, out uint eventId, out uint queryStatusId)
        {
            MySqlParameter begDTPar = new MySqlParameter("@begin_dt", MySqlDbType.DateTime);
            begDTPar.Value = begDT;

            MySqlParameter endDTPar = new MySqlParameter("@end_dt", MySqlDbType.DateTime);
            endDTPar.Value = endDT;

            MySqlParameter headingPar = new MySqlParameter("@e_heading", MySqlDbType.VarChar);
            headingPar.Value = heading;

            MySqlParameter textPar = new MySqlParameter("@e_text", MySqlDbType.VarChar);
            textPar.Value = text;

            MySqlParameter custIdPar = new MySqlParameter("@cust_id", MySqlDbType.UInt32);
            custIdPar.Value = userId;

            MySqlParameter custKeyPar = new MySqlParameter("@cust_key", MySqlDbType.VarChar);
            custKeyPar.Value = userKey;

            MySqlParameter eventIdPar = new MySqlParameter("@event_id", MySqlDbType.UInt32);
            eventIdPar.Direction = System.Data.ParameterDirection.Output;

            MySqlParameter queryStatusIdPar = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatusIdPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(begDTPar);
            parameters.Add(endDTPar);
            parameters.Add(headingPar);
            parameters.Add(textPar);
            parameters.Add(custIdPar);
            parameters.Add(custKeyPar);
            parameters.Add(eventIdPar);
            parameters.Add(queryStatusIdPar);

            ExecuteProcedure("complex_event_create", parameters);
            eventId = (uint)eventIdPar.Value;
            queryStatusId = (uint)queryStatusIdPar.Value;
        }

        public void updateEvent(uint eventId, string heading, string text, DateTime begDT, DateTime endDT, out uint queryStatusId)
        {
            MySqlParameter eventIdPar = new MySqlParameter("@event_id", MySqlDbType.UInt32);
            eventIdPar.Value = eventId;

            MySqlParameter begDTPar = new MySqlParameter("@begin_dt", MySqlDbType.DateTime);
            begDTPar.Value = begDT;

            MySqlParameter endDTPar = new MySqlParameter("@end_dt", MySqlDbType.DateTime);
            endDTPar.Value = endDT;

            MySqlParameter headingPar = new MySqlParameter("@e_heading", MySqlDbType.VarChar);
            headingPar.Value = heading;

            MySqlParameter textPar = new MySqlParameter("@e_text", MySqlDbType.VarChar);
            textPar.Value = text;

            MySqlParameter custIdPar = new MySqlParameter("@cust_id", MySqlDbType.UInt32);
            custIdPar.Value = userId;

            MySqlParameter custKeyPar = new MySqlParameter("@cust_key", MySqlDbType.VarChar);
            custKeyPar.Value = userKey;

            MySqlParameter queryStatusIdPar = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatusIdPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(eventIdPar);
            parameters.Add(begDTPar);
            parameters.Add(endDTPar);
            parameters.Add(headingPar);
            parameters.Add(textPar);
            parameters.Add(custIdPar);
            parameters.Add(custKeyPar);
            parameters.Add(queryStatusIdPar);

            ExecuteProcedure("complex_event_update", parameters);
            queryStatusId = (uint)queryStatusIdPar.Value;
        }

        public void deleteEvent(uint eventId, out uint queryStatusId)
        {
            MySqlParameter eventIdPar = new MySqlParameter("@event_id", MySqlDbType.UInt32);
            eventIdPar.Value = eventId;

            MySqlParameter custIdPar = new MySqlParameter("@cust_id", MySqlDbType.UInt32);
            custIdPar.Value = userId;

            MySqlParameter custKeyPar = new MySqlParameter("@cust_key", MySqlDbType.VarChar);
            custKeyPar.Value = userKey;

            MySqlParameter queryStatusIdPar = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatusIdPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(eventIdPar);
            parameters.Add(custIdPar);
            parameters.Add(custKeyPar);
            parameters.Add(queryStatusIdPar);

            ExecuteProcedure("complex_event_delete", parameters);
            queryStatusId = (uint)queryStatusIdPar.Value;
        }

        public Echo getAvailableEvents()
        {
            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdPar.Value = userId;

            return ReadProcedure("get_available_events", userIdPar);
        }
        // event methods >>>>

        // <<<< user methods
        public Echo getUsersData()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            return ReadProcedure("get_users_data", parameters);
        }

        public void userRegister(string lastName, string firstName, string middleName, out uint userId, out string pwd, out uint queryStatus)
        {
            MySqlParameter lName = new MySqlParameter("@l_name", MySqlDbType.VarChar);
            lName.Value = lastName;

            MySqlParameter fName = new MySqlParameter("@f_name", MySqlDbType.VarChar);
            fName.Value = firstName;

            MySqlParameter mName = new MySqlParameter("@m_name", MySqlDbType.VarChar);
            mName.Value = middleName;

            MySqlParameter custIdPar = new MySqlParameter("@cust_id", MySqlDbType.UInt32);
            custIdPar.Value = this.userId;

            MySqlParameter custKeyPar = new MySqlParameter("@cust_key", MySqlDbType.VarChar);
            custKeyPar.Value = userKey;

            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdPar.Direction = System.Data.ParameterDirection.Output;

            MySqlParameter pwdPar = new MySqlParameter("@pwd", MySqlDbType.VarChar);
            pwdPar.Direction = System.Data.ParameterDirection.Output;

            MySqlParameter queryStatusIdPar = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatusIdPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(lName);
            parameters.Add(fName);
            parameters.Add(mName);
            parameters.Add(custIdPar);
            parameters.Add(custKeyPar);
            parameters.Add(userIdPar);
            parameters.Add(pwdPar);
            parameters.Add(queryStatusIdPar);
            ExecuteProcedure("complex_user_register", parameters);

            userId = (uint)userIdPar.Value;
            pwd = pwdPar.Value.ToString();
            queryStatus = (uint)queryStatusIdPar.Value;
        }

        public void userDelete(uint userId, out uint queryStatusId)
        {
            MySqlParameter userIdPar = new MySqlParameter("@user_id", MySqlDbType.UInt32);
            userIdPar.Value = userId;

            MySqlParameter custIdPar = new MySqlParameter("@cust_id", MySqlDbType.UInt32);
            custIdPar.Value = this.userId;

            MySqlParameter custKeyPar = new MySqlParameter("@cust_key", MySqlDbType.VarChar);
            custKeyPar.Value = userKey;

            MySqlParameter queryStatusIdPar = new MySqlParameter("@query_status", MySqlDbType.UInt32);
            queryStatusIdPar.Direction = System.Data.ParameterDirection.Output;

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(userIdPar);
            parameters.Add(custIdPar);
            parameters.Add(custKeyPar);
            parameters.Add(queryStatusIdPar);

            ExecuteProcedure("complex_user_delete", parameters);
            queryStatusId = (uint)queryStatusIdPar.Value;
        }

        // user methods >>>>

        /* public List<Dictionary<string, object>> ReadQuery(string query)
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
        */

        public Echo ReadProcedure(string procedureName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            Echo result = new Echo();

            OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            bool firstIteration = true;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (firstIteration)
                        result.AddColumns(reader.GetName(i));
                    result.AddValue(reader.GetName(i), reader.GetValue(i));
                }
                firstIteration = false;
            }
            reader.Close();
            CloseConnection();

            return result;
        }

        public Echo ReadProcedure(string procedureName, MySqlParameter parameter)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(parameter);
            return ReadProcedure(procedureName, parameters);
        }

        public void ExecuteProcedure(string procedureName, List<MySqlParameter> parameters)
        {
            MySqlCommand command = new MySqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters.ToArray());

            OpenConnection();
            command.ExecuteScalar();
            CloseConnection();
        }

        // >>>> Database reading methods <<<<

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
