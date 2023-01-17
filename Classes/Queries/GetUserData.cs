using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleR.Classes.Queries
{
    class GetUserData : Query
    {

        public GetUserData(Client client, User customer) : base(client, customer)
        {
            requiredParamsHint = "1. User ID";
            queryTemplate = "SELECT * FROM users WHERE `ID` = {0};";
        }
    }
}
