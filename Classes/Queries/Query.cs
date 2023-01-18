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
        protected Dictionary<string, object> customerData;
        protected uint customerAccessLevel;
        public Query(Client client, uint customerId)
        {
            this.client = client;
            customerData = client.getUserData(customerId);
            customerAccessLevel = client.getUserAccessLevel(customerId);
        }

        public virtual bool isAvailable(params object[] args)
        {
            return customerAccessLevel == 0;
        }

        public virtual List<Dictionary<string, object>> execute(params object[] args)
        {
            if (!isAvailable(args))
                throw new UnavailableQueryException();
            return client.readQuery(String.Format(queryTemplate, args));
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
    }
}
