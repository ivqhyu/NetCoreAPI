using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Daily> Daily { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;}
    //     protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Daily>()
    //         .HasOne(d => d.HeThongPhanPhoi)
    //         .WithMany(htpp => htpp.Daily)
    //         .HasForeignKey(d => d.MaHTPP);
    // }

    }   
}