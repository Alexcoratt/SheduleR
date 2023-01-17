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
        protected string queryTemplate = "SELECT 1";
        public string requiredParamsHint = "No required params";
        protected Dictionary<string, object> customerData;
        public Query(Client client, uint customerId)
        {
            this.client = client;
            customerData = client.getUserData(customerId);
        }

        public virtual bool isAvailable(params object[] args)
        {
            return true;
        }

        public virtual List<Dictionary<string, object>> execute(params object[] args)
        {
            if (!isAvailable(args))
                throw new UnavailableQueryException();
            return client.executeQuery(String.Format(queryTemplate, args));
        }

        public string executeToString(params object[] args)
        {
            try
            {
                List<Dictionary<string, object>> data = execute(args);
                if (!data.Any())
                    return "No Data";
                StringBuilder sb = new StringBuilder();
                foreach (Dictionary<string, object> line in data)
                {
                    foreach (object datum in line.Values)
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

        public virtual object executeManually(params object[] args) // enter all parameters manually (only for superusers in inhereted classes)
        {
            return client.executeQuery(String.Format(queryTemplate, args));
        }
    }
}
