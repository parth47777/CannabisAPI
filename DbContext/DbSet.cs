using Microsoft.EntityFrameworkCore;
using CannabisAPI.Models;

namespace CannabisAPI.Data
{
    public class DbSet : DbContext
    {
        public DbSet(DbContextOptions<DbSet> options)
            : base(options)
        {
        }

        public DbSet<CannabisAPI.Entities.AccessCode> AccessCodes { get; set; }
        public DbSet<CannabisAPI.Entities.Agency> Agencies { get; set; }
        public DbSet<CannabisAPI.Entities.AuditCannabisReport> AuditCannabisReports { get; set; }
        public DbSet<CannabisAPI.Entities.AuditContactInfo> AuditContactInfos { get; set; }
        public DbSet<CannabisAPI.Entities.CannabisReport> CannabisReports { get; set; }
        public DbSet<CannabisAPI.Entities.CannabisReportMain> CannabisReportMains { get; set; }
        public DbSet<CannabisAPI.Entities.ContactInfo> ContactInfos { get; set; }
        public DbSet<CannabisAPI.Entities.NotificationTracking> NotificationTrackings { get; set; }

        // Add additional DbSet properties for the other tables in your database schema
        // ...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configuration goes here, for example:
            modelBuilder.Entity<CannabisAPI.Entities.AccessCode>()
                .HasKey(ac => ac.AC_ID);

            modelBuilder.Entity<CannabisAPI.Entities.Agency>()
                .HasKey(a => a.Agency_ID);

            // Add additional Fluent API configurations here
            // ...

            base.OnModelCreating(modelBuilder);
        }
    }
}