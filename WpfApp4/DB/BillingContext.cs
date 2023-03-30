using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.DB
{
    public class BillingContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        
        public BillingContext() 
        {
            Database.Migrate();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=admin;Password=root;Host=192.168.50.194;Port=6000;Database=korkodinov;");
        }
    }
}
