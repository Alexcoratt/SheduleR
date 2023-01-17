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
            requiredParamsHint =
                "1. First ID" +
                "2. Second ID\n" +
                "3. Connection type (0 - User/Group; 1 - Event/Group; 2 - Note/Group)\n";
            queryTemplate =
                "INSERT INTO connections " +
                "(`First ID`, `Second ID`, `Connection Type`, `Creation DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}'); " +
                "SELECT * FROM connections WHERE `First ID` = {0} AND `Second ID` = {1};";
        }

        public override bool isAvailable(params object[] args)
        {
            byte customerAccess = client.getUserAccessLevel((uint)customerData["ID"]);
            byte groupAccess = (byte)client.getGroupData((uint)(int)args[1])["Access Level"];
            bool isCustomerInGroup = 
                client.getGroups((uint)customerData["ID"]).Contains((uint)(int)args[1]);
            return customerAccess <= 1 && groupAccess >= customerAccess ||
                        customerAccess == 2 && isCustomerInGroup;
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            return base.execute(args[0], args[1], args[2], client.getServerDateTime());
        }
    }
}
