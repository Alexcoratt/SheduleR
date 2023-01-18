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
            queryTemplate =
                "INSERT INTO connections " +
                "(`First ID`, `Second ID`, `Connection Type`, `Creation DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}'); " +
                "SELECT * FROM connections WHERE `First ID` = {0} AND `Second ID` = {1};";
        }
    }
}
