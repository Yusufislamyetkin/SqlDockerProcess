using FirstWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstWebAPI.Data
{
    public class FirstAPIContext : DbContext
    {

        public FirstAPIContext(DbContextOptions<FirstAPIContext> options)
           : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

    }
}
