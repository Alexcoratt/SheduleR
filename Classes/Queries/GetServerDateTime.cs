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
            queryTemplate = "SELECT NOW();";
        }

        public override List<List<object>> execute(params object[] args)
        {
            List<List<object>> result = new List<List<object>>();
            List<object> subres = new List<object>();
            subres.Add(executeToObject(args));
            result.Add(subres);
            return result;
        }

        public override object executeToObject(params object[] args)
        {
            DateTime dt = (DateTime)client.executeQuery(queryTemplate).First().First();
            string result = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return result;
        }
    }
}
