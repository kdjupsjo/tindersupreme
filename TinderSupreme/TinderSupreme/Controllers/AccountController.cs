using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using TinderSupreme.BLL;
using TinderSupreme.Models;

namespace TinderSupreme
{
    public class AccountController : ApiController
    {
        TSContext tinderS;

        public AccountController( )
        {
            tinderS = new TSContext();
        }
        
        // GET api/values
        public IEnumerable<String> Get()
        {
            var acs = from a in tinderS.Accounts select a.UserName;

            return acs;
        }

        
        // GET api/values/
        public string Get(int id)
        {
            return "value";
        }
        

        // POST /api/account
        public String Post(CreateAccountModel account)
        {
            return AccountBLL.NewUser(account.account, account.verifyPass);
        }

        [Route("api/account/delete")]
        public String Post(Account account)
        {
            AccountBLL.DeleteUser(account);
            return "Deleted";
        }

    }
}
