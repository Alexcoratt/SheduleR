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
            requiredParamsHint =
                "1. User last name\n" +
                "2. User first name\n" +
                "3. User middle name (or empty string)\n";
            queryTemplate =
                "INSERT INTO users " +
                "(`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`, " +
                "`Registration DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}');";
        }

        public override bool isAvailable(params object[] args)
        {
            return client.getUserAccessLevel((uint)customerData["ID"]) <= 1;
        }

        public override List<Dictionary<string, object>> execute(params object[] args)
        {
            return base.execute(client.getFreeId("users"), "test", "test", 
                args[0], args[1], args[2], client.getServerDateTime());
        }

        public override object executeManually(params object[] args)
        {
            if (client.getUserAccessLevel((uint)customerData["ID"]) != 0)
                throw new UnavailableQueryException();
            return base.execute(args);
        }
    }
}
