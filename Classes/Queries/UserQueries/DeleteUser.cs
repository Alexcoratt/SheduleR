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
            queryTemplate = "DELETE FROM users WHERE `ID` = {0};";
        }
    }
}
