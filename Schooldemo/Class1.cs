using Microsoft.EntityFrameworkCore;
using System;

namespace Schooldemo
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=webd;integrated security =true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
