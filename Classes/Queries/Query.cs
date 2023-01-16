using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes.Queries
{
    abstract class Query
    {
        protected Client client;
        protected User customer;
        protected string queryTemplate = "SELECT 1";
        public Query(Client client, User customer)
        {
            this.client = client;
            this.customer = customer;
        }

        public bool isAvailable()
        {
            return true;
        }

        public List<List<object>> execute(params object[] args)
        {
            if (!isAvailable())
                throw new UnavailableQueryException();
            return client.executeQuery(String.Format(queryTemplate, args));
        }
        
    }
}
