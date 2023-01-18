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
            queryTemplate = 
                "INSERT INTO scheduler_schema.groups " +
                "(`ID`, `Name`, `Access Level`, `Members Maximum`, " +
                "`Creation DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{4}'); " +
                "SELECT * FROM scheduler_schema.groups WHERE `ID` = {0};";
        }
    }
}
