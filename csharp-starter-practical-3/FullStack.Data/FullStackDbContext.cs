using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public class FullStackDbContext : DbContext
    {
        //Implement the DbContext
        //
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-P4NT7P1\\SQLEXPRESS; database=FullStackAppData; Integrated Security=True");
        }
    }
}