using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TinderSupreme
{
    public class Account
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public String UserName { get; set; }
        public String Password { get; set; }
    }


    public class TSContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}