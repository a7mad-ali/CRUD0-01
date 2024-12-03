using Microsoft.EntityFrameworkCore;
using EmployeeAdminPortal.Models.Entities;
namespace EmployeeAdminPortal.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
