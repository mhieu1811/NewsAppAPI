using Microsoft.EntityFrameworkCore;
using DataAccessor.Entities;

namespace DataAccessor.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Comments> Comments { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Type> Types { get; set; }  

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //code first
            //db first
            //model first
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
