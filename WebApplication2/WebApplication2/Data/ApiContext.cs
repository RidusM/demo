using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Staffs> Staffs { get; set; }
        public DbSet<Statuses> Statuses { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
