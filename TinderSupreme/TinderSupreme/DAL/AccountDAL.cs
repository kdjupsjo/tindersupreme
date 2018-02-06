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

        public static bool IsValidAccount(Account account)
        {
            var acco = accountContext.Accounts
                .Where((ac) =>
                   ac.UserName.Equals(account.UserName) &&
                   ac.Password.Equals(account.Password)
                    )
                .First();

            return acco != null;
        }

        public static void Store(Account newAccount)
        {
            accountContext.Accounts.Add(newAccount);

            accountContext.SaveChanges();
        }

        public static void Delete(Account oldAccount)
        {
            accountContext.Accounts.Remove(oldAccount);

            accountContext.SaveChanges();
        }
    }
}