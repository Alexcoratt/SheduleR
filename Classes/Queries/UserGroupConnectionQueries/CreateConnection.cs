using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class CreateConnection : Query
    {
        public CreateConnection(Client client, uint customerId) : base(client, customerId)
        {
            requiredParamsHint = "1. User ID\n2. Group ID";
            queryTemplate =
                "INSERT INTO user_group_connections " +
                "(`User ID`, `Group ID`, `Creation DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}');";
        }

        public override bool isAvailable(params object[] args)
        {
            byte customerAccess = client.getUserAccessLevel((uint)customerData["ID"]);
            byte groupAccess = (byte)client.getUserGroupData((uint)(int)args[1])["Access Level"];
            List<uint> connectedGroupsId = client.getUserConnections((uint)customerData["ID"]);
            return customerAccess <= 1 && groupAccess >= customerAccess ||
                customerAccess == 2 && connectedGroupsId.Contains((uint) args[1]);
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            return base.execute(args[0], args[1], client.getServerDateTime());
        }
    }
}
