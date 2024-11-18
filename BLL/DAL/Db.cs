using Microsoft.EntityFrameworkCore;

namespace BLL.DAL
{
    public class Db : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public Db(DbContextOptions options) : base(options)
        {
            
        }
    }
}
