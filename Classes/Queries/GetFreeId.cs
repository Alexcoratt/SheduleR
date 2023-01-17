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
                "SELECT `ID` " +
                "FROM {0} " +
                "ORDER BY `ID`;";
        }

        public override List<List<object>> execute(params object[] args)
        {
            List<List<object>> result = new List<List<object>>();
            List<object> subres = new List<object>();
            subres.Add(nsExecute(args));
            result.Add(subres);
            return result;
        }

        public override object nsExecute(params object[] args)
        {
            if (!isAvailable())
                throw new UnavailableQueryException();
            uint lastValue = 0;
            IEnumerator<List<object>> enumerator = client.executeQuery(String.Format(queryTemplate, args)).GetEnumerator();
            while (enumerator.MoveNext() && (uint)enumerator.Current.First() - lastValue <= 1)
                lastValue = (uint)enumerator.Current.First();
            return lastValue + 1;
        }
    }
}
