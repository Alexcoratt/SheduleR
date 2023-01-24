using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleR.Classes.Queries
{
    abstract public class Query
    {
        protected Client client;
        protected uint custId;
        protected string custKey;
        public Query(Client client, uint custId, string custKey)
        {
            this.client = client;

        }
    }
}
