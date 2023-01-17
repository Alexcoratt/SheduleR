using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class DeleteUser : Query
    {
        public DeleteUser(Client client, uint customerId) : base(client, customerId)
        {
            requiredParamsHint = "1. User ID";
            queryTemplate = "DELETE FROM users WHERE `ID` = {0};";
        }

        public override bool isAvailable(params object[] args)
        {
            byte customerAccess = client.getUserAccessLevel((uint)customerData["ID"]);
            byte delAccess = client.getUserAccessLevel((uint)(int)args[0]);
            return customerAccess <= 1 && customerAccess < delAccess;
        }
    }
}
