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
        public string requiredParamsHint = "No required params";
        protected byte customerAccessLevel;
        public Query(Client client, User customer)
        {
            this.client = client;
            this.customer = customer;
        }

        public virtual List<List<object>> execute(params object[] args)
        {
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

        public virtual object executeToObject(params object[] args) // not standart execution
        {
            return execute(args);
        }

        public virtual object executeManually(params object[] args) // enter all parameters manually (only for superusers in inhereted classes)
        {
            return execute(args);
        }
    }
}
