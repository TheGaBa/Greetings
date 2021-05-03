using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
        }
    }
}