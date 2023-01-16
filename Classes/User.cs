using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;
using ScheduleR.Classes.Queries;

namespace ScheduleR.Classes
{
    class User
    {
        private uint id;
        private string lastName, firstName, middleName, login;
        private Client client;

        public User(Client client, uint id){
            this.client = client;
            setFromDB(id);
        }

        // <<<< Setting methods >>>>
        public void setFromDB(uint id)
        {
            Query getUserData = new GetUserData(client, this);
            IEnumerator<object> enumerator = getUserData.execute(id).First().GetEnumerator();
            enumerator.MoveNext();
            setId((uint)enumerator.Current);

            enumerator.MoveNext();
            setLogin((string)enumerator.Current);

            enumerator.MoveNext();
            enumerator.MoveNext();
            setLastName((string)enumerator.Current);

            enumerator.MoveNext();
            setFirstName((string)enumerator.Current);

            enumerator.MoveNext();
            setMiddleName((string)enumerator.Current);
        }
        public void setLogin(string login)
        {
            this.login = login;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setMiddleName(string middleName)
        {
            this.middleName = middleName;
        }
        public void setId(uint id)
        {
            this.id = id;
        }
        public void setClient(Client client)
        {
            this.client = client;
        }
        // >>>> Setting methods <<<<

        // <<<< Getting methods >>>>
        public uint getId()
        {
            return id;
        }
        public string getLogin()
        {
            return login;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getMiddleName()
        {
            return middleName;
        }
        override
        public string ToString()
        {
            return String.Format("{0,5}\t{1}\t{2} {3} {4}",
                id, login, lastName, firstName, middleName);
        }
        /*public List<uint> getGroupsId()
        {

        }*/
        // >>>> Getting methods <<<<
    }
}
