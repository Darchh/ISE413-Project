using Microsoft.EntityFrameworkCore;

namespace BLL.DAL
{
    public class Db : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Matches> Matches { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public Db(DbContextOptions options) : base(options)
        {
            
        }
    }
}
