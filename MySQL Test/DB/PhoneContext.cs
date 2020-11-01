using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MySQL_Test.DB
{
    class PhoneContext : DbContext
    {
        public DbSet<phone> Phones { get; set; }
        public DbSet<user> User { get; set; }

        public PhoneContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=phones;uid=root;password=0013669");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<phone>().HasKey(c => new { c.id});
            modelBuilder.Entity<user>().HasKey(c => new { c.id, c.username, c.email});
        }
    }
}
