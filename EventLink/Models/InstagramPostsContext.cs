using Microsoft.EntityFrameworkCore;

namespace EventLink.Models
{
    public class InstagramPostsContext: DbContext
    {
        public InstagramPostsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<InstagramPosts> InstagramPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var posts = (InstagramPosts[]);
            //modelBuilder.Entity<InstagramPosts>().HasData(
            //    new InstagramPosts
            //    {
            //        DisplayUrl = ,

            //    }
        }
    }
}
