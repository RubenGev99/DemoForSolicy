using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.DAL
{
    public class AccountsContext : DbContext
    {
        public AccountsContext(DbContextOptions<AccountsContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Owner> Owners { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Owner>().ToTable("Owners");
        }

    }
}
