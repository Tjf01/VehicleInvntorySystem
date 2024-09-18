using VehicleInventorySystem.Models;

namespace VehicleInventorySystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Vehicles.Any())
            {
                return; // DB has been seeded
            }

            var vehicles = new Vehicle[]
            {
                new Vehicle { Make = "Toyota", Model = "Camry", Year = 2020, Price = 24000, Description = "Reliable sedan." },
                new Vehicle { Make = "Ford", Model = "Mustang", Year = 2019, Price = 35000, Description = "Sporty coupe." }
            };

            foreach (var v in vehicles)
            {
                context.Vehicles.Add(v);
            }
            context.SaveChanges();
        }
    }
}
