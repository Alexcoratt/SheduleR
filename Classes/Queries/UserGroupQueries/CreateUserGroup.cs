using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    class CreateUserGroup : Query
    {
        public CreateUserGroup(Client client, User customer) : base(client, customer)
        {
            customerAccessLevel = (byte)new GetUserAccessLevel(client, customer).executeToObject(customer.getId());
            requiredParamsHint = 
                "1. Group name\n" +
                "2. Access Level\n" +
                "3. The maximum number of members";
            queryTemplate = 
                "INSERT INTO user_groups " +
                "(`ID`, `Name`, `Access Level`, `Members Maximum`, " +
                "`Creation DateTime`, `Last Update DateTime`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{4}');";
        }

        public override List<List<object>> execute(params object[] args)
        {
            if (customerAccessLevel > 1 || (int)args[1] <= customerAccessLevel || (uint)(int)args[2] < 2)
                throw new UnavailableQueryException();
            uint groupId = (uint)new GetFreeId(client, customer).executeToObject("user_groups");
            string dt = (string)new GetServerDateTime(client, customer).executeToObject();
            return base.execute(groupId, args[0], args[1], args[2], dt);
        }

        public override object executeManually(params object[] args)
        {
            if (customerAccessLevel > 0)
                throw new UnavailableQueryException();
            return base.execute(args);
        }
    }
}
