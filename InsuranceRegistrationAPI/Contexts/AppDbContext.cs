using InsuranceRegistrationAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuranceRegistrationAPI.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
