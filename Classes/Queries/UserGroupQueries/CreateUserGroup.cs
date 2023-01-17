using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class CreateUserGroup : Query
    {
        public CreateUserGroup(Client client, uint customerId) : base(client, customerId)
        {
            requiredParamsHint = 
                "1. Group name\n" +
                "2. Access Level\n" +
                "3. The maximum number of members";
            queryTemplate = 
                "INSERT INTO user_groups " +
                "(`ID`, `Name`, `Access Level`, `Members Maximum`, " +
                "`Creation DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{4}');";
        }

        public override bool isAvailable(params object[] args)
        {
            uint access = client.getUserAccessLevel((uint)customerData["ID"]);
            return access <= 1 && (int)args[2] > access && (int)args[3] > 1;
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            return base.execute(client.getFreeId("user_groups"), 
                args[0], args[1], args[2], client.getServerDateTime());
        }

        public override object executeManually(params object[] args)
        {
            if (client.getUserAccessLevel((uint)customerData["ID"]) > 0)
                throw new UnavailableQueryException();
            return base.execute(args);
        }
    }
}
