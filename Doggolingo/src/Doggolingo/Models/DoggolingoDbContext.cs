using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Doggolingo.Models
{
    public class DoggolingoDbContext : IdentityDbContext<ApplicationUser>
    {
        public DoggolingoDbContext()
        {
        }

        public virtual DbSet<DogParent> DogParents { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Step> Steps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Doggolingo; integrated security=True");
        }

        public DoggolingoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}