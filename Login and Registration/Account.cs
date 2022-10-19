using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Registration
{
    internal class Account
    {
        private static List<Account> accounts = new List<Account>();
        private string username;
        private string password;

        public Account(string _u, string _p)
        {
            username = _u;
            password = _p;
        }

        static public bool RegisterAccount(string username, string password)
        {
            foreach (Account account in accounts)
            {
                if (account.username == username) return false;
            }
            accounts.Add(new Account(username, password));
            return true;
        }

        static public bool Login(string username, string password)
        {
            foreach (Account account in accounts)
            {
                if (account.username == username)
                {
                    if (account.password == password) return true;
                    return false;
                }
            }
            return false;
        }
    }
}
