using DevelopmentTestCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentTestCrud.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
