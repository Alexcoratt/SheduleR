using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleR.Classes.Queries
{
    class GetUserGroupsData : Query
    {
        public GetUserGroupsData(Client client, User customer) : base(client, customer)
        {
            requiredParamsHint = "1. User ID";
            queryTemplate = 
                "SELECT user_groups.* " +
                "FROM user_groups " +
                "INNER JOIN (user_group_connections) " +
                "ON (user_groups.`ID` = user_group_connections.`Group ID`) " +
                "WHERE user_group_connections.`User ID` = {0};";
        }
    }
}
