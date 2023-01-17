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
        public CreateUser(Client client, User customer) : base(client, customer)
        {
            customerAccessLevel = (byte) new GetUserAccessLevel(client, customer).executeToObject(customer.getId());
            requiredParamsHint =
                "1. User last name\n" +
                "2. User first name\n" +
                "3. User middle name (or empty string)\n" +
                "4. User individual group access level";
            queryTemplate =
                "INSERT INTO users " +
                "(`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`, " +
                "`Registration DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}');" +
                "INSERT INTO user_groups " +
                "(`ID`, `Name`, `Access Level`, `Members Maximum`, " +
                "`Creation DateTime`, `Last Update DateTime`) " +
                "VALUES ('{7}', CONCAT('IG', '{1}'), {8}, '1', '{6}', '{6}');";
        }
        public override List<List<object>> execute(params object[] args)
        {
            if (customerAccessLevel > 1 || (byte)args[3] <= customerAccessLevel)
                throw new UnavailableQueryException();
            Query gfid = new GetFreeId(client, customer);
            uint userID = (uint)(gfid.executeToObject("users"));
            uint igID = (uint)(gfid.executeToObject("user_groups"));
            string serverDateTime = (string) new GetServerDateTime(client, customer).executeToObject();
            return base.execute(
                userID, "test", "test", args[0], args[1], args[2], serverDateTime,
                igID, args[3]
                );
        }

        public override object executeManually(params object[] args)
        {
            if (customerAccessLevel != 0)
                throw new UnavailableQueryException();
            return base.execute(args);
        }
    }
}
