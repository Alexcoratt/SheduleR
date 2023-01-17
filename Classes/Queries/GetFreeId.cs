using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class GetFreeId : Query
    {
        public GetFreeId(Client client, User customer) : base (client, customer)
        {
            requiredParamsHint = "1. Table name";
            queryTemplate =
                "SELECT `ID` as 'Free ID'" +
                "FROM {0} " +
                "ORDER BY `ID`;";
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres = new Dictionary<string, object>();
            subres.Add("Free ID", executeToObject(args));
            result.Add(subres);
            return result;
        }

        public override object executeToObject(params object[] args)
        {
            uint lastValue = 0;
            IEnumerator<Dictionary<string, object>> enumerator = client.executeQuery(String.Format(queryTemplate, args)).GetEnumerator();
            while (enumerator.MoveNext() && (uint)enumerator.Current["Free ID"] - lastValue <= 1)
                lastValue = (uint)enumerator.Current["Free ID"];
            return lastValue + 1;
        }
    }
}
