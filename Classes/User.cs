using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleR.Classes
{
    class User
    {
        private uint id;
        private string lastName, firstName, middleName, login;
        public User(){}

        public User(List<object> echo)
        {
            setFromEcho(echo);
        }

        public void setFromEcho(List<object> echo)
        {
            IEnumerator<object> enumerator = echo.GetEnumerator();
            enumerator.MoveNext();
            id = (uint)enumerator.Current;

            enumerator.MoveNext();
            login = (string)enumerator.Current;
            enumerator.MoveNext();

            enumerator.MoveNext();
            lastName = (string)enumerator.Current;
            
            enumerator.MoveNext();
            firstName = (string)enumerator.Current;
            
            enumerator.MoveNext();
            middleName = (string)enumerator.Current;
        }

        public uint getId()
        {
            return id;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }

        public string getLogin()
        {
            return login;
        }

        public void setName(string lastName, string firstName, string middleName="")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
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
    }
}
