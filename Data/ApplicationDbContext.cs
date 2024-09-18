using Microsoft.EntityFrameworkCore;
using VehicleInventorySystem.Models;

namespace VehicleInventorySystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
