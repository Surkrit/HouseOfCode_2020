using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HouseOfCode_2020.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}