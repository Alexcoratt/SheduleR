using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class GetUserGroupAccessLevel : Query
    {
        public GetUserGroupAccessLevel(Client client, User customer) : base(client, customer)
        {
            requiredParamsHint = "1. Group ID";
            queryTemplate = "SELECT `Access Level` FROM user_groups WHERE `ID` = {0};";
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
            return (byte)base.execute(args).First().First();
        }
    }
}
