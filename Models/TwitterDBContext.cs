using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class TwitterDBContext:DbContext
    {
        public TwitterDBContext(DbContextOptions<TwitterDBContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<Comment>().Property(b => b.deleted_at)
            .IsRequired(false);
            base.OnModelCreating(modelBuilder);
        }
    }
}
