using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class ConnectUserToGroup : Query
    {
        public ConnectUserToGroup(Client client, User customer) : base(client, customer)
        {
            customerAccessLevel = (byte)new GetUserAccessLevel(client, customer).executeToObject(customer.getId());
            requiredParamsHint = "1. User ID\n2. Group ID";
            queryTemplate =
                "INSERT INTO user_group_connections " +
                "(`User ID`, `Group ID`, `Creation DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}');";
        }

        /*
        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            bool isCustomerInGroup = (bool) new IsUserInGroup(client, customer).executeToObject(customer.getId(), args[1]);
            if (customerAccessLevel > 2 ||  || customerAccessLevel == 2 && !isCustomerInGroup)
        }
        */
    }
}
