using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FullStack.Data
{
    public class FullStackDbContext : DbContext
    {
        // Implement the DbContext

        public FullStackDbContext(DbContextOptions<FullStackDbContext> options)
                  : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<User> Users { get; set; }

        //PRACTICAL 3
        //
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        "Data Source=DESKTOP-P4NT7P1\\SQLEXPRESS; database=FullStackAppData; Integrated Security=True");
        //}
    
        //For the Delete in the API Controller
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .HasMany(b => b.InvoiceItems)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}