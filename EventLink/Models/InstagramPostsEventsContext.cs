using Microsoft.EntityFrameworkCore;

namespace EventLink.Models
{
    public class InstagramPostsEventsContext : DbContext
    {
        public DbSet<InstagramPostsEvents> InstagramPostsEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }

    public class InstagramPostsEventsConcertsContext : DbContext
    {
        public DbSet<InstagramPostsEventsConcerts> InstagramPostsEventsConcerts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }

    public class InstagramPostsEventsSportsContext : DbContext
    {
        public DbSet<InstagramPostsEventsSports> InstagramPostsEventsSports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }

    public class InstagramPostsEventsRestaurantsContext : DbContext
    {
        public DbSet<InstagramPostsEventsRestaurants> InstagramPostsEventsRestaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
