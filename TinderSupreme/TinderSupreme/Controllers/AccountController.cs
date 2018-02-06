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
        public IEnumerable<Account> Get()
        {
            var acs = from a in tinderS.Accounts select a;

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

        public String Post(Account account)
        {
            return "Deleted";
        }

        /*
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        */
    }
}
