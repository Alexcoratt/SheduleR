using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleR.Classes.Queries
{
    class AddUser : Query
    {
        public AddUser(Client client, uint customerId) : base(client, customerId)
        {

        }
    }
}
