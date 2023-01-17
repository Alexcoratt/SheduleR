using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    abstract class Query
    {
        protected Client client;
        protected User customer;
        protected string queryTemplate = "SELECT 1";
        protected string requiredParamsHint = "No required params";
        protected uint customerAccessLevel;
        public Query(Client client, User customer)
        {
            this.client = client;
            this.customer = customer;
        }

        public virtual bool isAvailable()
        {
            return true;
        }

        public virtual List<List<object>> execute(params object[] args)
        {
            if (!isAvailable())
                throw new UnavailableQueryException();
            return client.executeQuery(String.Format(queryTemplate, args));
        }

        public string executeToString(params object[] args)
        {
            try
            {
                List<List<object>> data = execute(args);
                if (!data.Any())
                    return "No Data";
                StringBuilder sb = new StringBuilder();
                foreach (List<object> line in data)
                {
                    foreach (object datum in line)
                        sb.Append(datum.ToString()).Append("\t");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception err)
            {
                return "ERROR " + err.ToString();
            }
        }

        public virtual object nsExecute(params object[] args) // not standart execution
        {
            return execute(args);
        }

        public virtual string requiredParams()
        {
            return requiredParamsHint;
        }
    }
}
