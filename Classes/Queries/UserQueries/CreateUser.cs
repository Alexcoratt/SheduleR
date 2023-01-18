using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.Types;
using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class CreateUser : Query
    {
        public CreateUser(Client client, uint customerId) : base(client, customerId)
        {
            queryTemplate =
                "INSERT INTO users " +
                "(`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`, " +
                "`Registration DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}'); " +
                "" +
                "SELECT `ID`, `Login`, `Last Name`, `First Name`, `Middle Name`, " +
                "`Registration DateTime`, `Last Update DateTime` " +
                "FROM users WHERE `ID` = '{0}';";
        }
    }
}
