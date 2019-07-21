using EntityFrameWorkCorePractice.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameWorkCorePractice
{
    public class DemoContext: DbContext 
    {
        public DbSet<SiteUser> Siteusers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DemoContext(DbContextOptions options) :
          base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Course>()
                .HasOne<SiteUser>(c => c.SiteUser)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SiteUserId);
        }
    }
}