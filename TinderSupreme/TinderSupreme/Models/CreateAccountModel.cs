using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinderSupreme.Models
{
    public class CreateAccountModel
    {
        public Account account { get; set; }
        public String verifyPass { get; set; }
    }
}