using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class GetServerDateTime : Query
    {
        public GetServerDateTime(Client client, User customer) : base(client, customer)
        {
            queryTemplate = "SELECT NOW() as 'Current Time';";
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres = new Dictionary<string, object>();
            subres.Add("Current Time", executeToObject(args));
            result.Add(subres);
            return result;
        }

        public override object executeToObject(params object[] args)
        {
            DateTime dt = (DateTime)client.executeQuery(queryTemplate).First()["Current Time"];
            string result = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return result;
        }
    }
}
