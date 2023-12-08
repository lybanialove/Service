using Microsoft.EntityFrameworkCore;
using Service.Entites;

namespace Service
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> users { get; set; }
        public DbSet<Record> records { get; set; }
        public DbSet<Master> masters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=admin");
            
        }
    }
}
