using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinderSupreme.DAL
{
    public class AccountDAL
    {
        public static TSContext accountContext= new TSContext();

        public static bool IsUsernameInDB( String Username )
        {
            var userAccount = accountContext.Accounts.Find(Username);

            return userAccount != null;
        }

        public static void Store(Account newAccount)
        {
            accountContext.Accounts.Add(newAccount);

            accountContext.SaveChanges();
        }
    }
}