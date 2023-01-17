using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class CreateGroup : Query
    {
        public CreateGroup(Client client, uint customerId) : base(client, customerId)
        {
            requiredParamsHint = 
                "1. Group name\n" +
                "2. Access Level\n" +
                "3. The maximum number of members";
            queryTemplate = 
                "INSERT INTO scheduler_schema.groups " +
                "(`ID`, `Name`, `Access Level`, `Members Maximum`, " +
                "`Creation DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{4}'); " +
                "SELECT * FROM scheduler_schema.groups WHERE `ID` = {0};";
        }

        public override bool isAvailable(params object[] args)
        {
            uint access = client.getUserAccessLevel((uint)customerData["ID"]);
            return access <= 1 && (int)args[2] > access && (int)args[3] > 1;
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            return base.execute(client.getFreeId("scheduler_schema.groups"), 
                args[0], args[1], args[2], client.getServerDateTime());
        }

        public override object executeManually(params object[] args)
        {
            if (client.getUserAccessLevel((uint)customerData["ID"]) > 0)
                throw new UnavailableQueryException();
            return base.executeManually(args);
        }
    }
}
