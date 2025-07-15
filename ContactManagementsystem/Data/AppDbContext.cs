using Microsoft.EntityFrameworkCore;
using ContactManagementSystem.Models;
namespace ContactManagementSystem.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}