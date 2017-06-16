using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PDS.Models.User;
namespace PDS.Repository
{
    public class UserContext : DbContext
    {
        public UserContext() : base(@"Data Source=LP-Manishjha\SQLExpress;Initial Catalog=PDS_DB;Integrated Security=SSPI;")
        {

        }
        public DbSet<UserPersonalDetail> UserPersonalDetails { get; set; }
        public DbSet<UserLoginDetail> UserLoginDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPersonalDetail>().HasKey(x => x.FirstName).HasKey(x=>x.LastName).HasKey(x=> x.Address); //primary key

            modelBuilder.Entity<UserLoginDetail>().HasKey(x => x.UserName);
        }
    }
}