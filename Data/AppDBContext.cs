using HNGProjectTaskOneAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace HNGProjectTaskOneAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<HNGStudent> HNGStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //add seed data
            modelBuilder.Entity<HNGStudent>().HasData(
                new HNGStudent { Id = 1, slackUsername = "Olisaemeka", backend = true, age = 30, bio = "I am a backend developer" }
            );
        }
    }
}
