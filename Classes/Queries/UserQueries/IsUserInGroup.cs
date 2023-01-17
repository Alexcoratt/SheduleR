using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class IsUserInGroup : Query
    {
        public IsUserInGroup(Client client, User customer) : base(client, customer)
        {
            requiredParamsHint = "1. User ID\n2. Group ID";
            queryTemplate =
                "SELECT * FROM user_group_connections " +
                "WHERE `User ID` = {0} AND `Group ID` = {1};";
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            Dictionary<string, object> subres = new Dictionary<string, object>();
            subres.Add("Is User In Group", executeToObject(args));
            result.Add(subres);
            return result;
        }

        public override object executeToObject(params object[] args)
        {
            return base.execute(args).Any();
        }
    }
}
