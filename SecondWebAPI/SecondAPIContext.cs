
using Microsoft.EntityFrameworkCore;
using SecondWebAPI.Entity;

namespace SecondWebAPI
{
    public class SecondAPIContext : DbContext
    {

        public SecondAPIContext(DbContextOptions<SecondAPIContext> options)
           : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Order> orders { get; set; }

    }
}
