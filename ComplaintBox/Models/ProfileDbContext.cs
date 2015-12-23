using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComplaintBox.Models
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Profile> User { get; set; }
    }
}