using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WSA_Final_Project.Models
{
    public class WSAFinalContext : DbContext
    {
        public WSAFinalContext(DbContextOptions<WSAFinalContext> options)
           : base(options)
        { }

        public DbSet<Filament> Filaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filament>().HasData(
                new Filament
                {
                    FilamentId = 1,
                    Material = "PLA",
                    MaterialFull = "Polylactic Acid",
                    Description = "PLA is a biodegradable thermoplastic derived from renewable resources like corn starch or sugarcane. It is one of the most commonly used filaments in 3D printing due to its ease of use, low warping, and wide availability. PLA is ideal for beginners and is suitable for a variety of applications, including prototypes, models, and decorative items."
                },
                new Filament
                {
                    FilamentId = 2,
                    Material = "ABS",
                    MaterialFull = "Acrylonitrile Butadiene Styrene",
                    Description = "ABS is a strong and durable thermoplastic that is commonly used in 3D printing. It is known for its toughness, impact resistance, and ability to withstand higher temperatures compared to PLA. ABS is often used for functional parts, mechanical components, and objects that require strength and durability. However, it can be more challenging to print with due to its tendency to warp and emit fumes during printing."
                },
                new Filament
                {
                    FilamentId = 3,
                    Material = "PETG",
                    MaterialFull = "Polyethylene Terephthalate Glycol",
                    Description = "PETG is a popular filament that combines the ease of use of PLA with the strength and durability of ABS. It is known for its excellent layer adhesion, low warping, and resistance to moisture. PETG is often used for functional parts, mechanical components, and objects that require strength and durability. It is also food-safe and can be used for applications such as water bottles and food containers."
                }
            );
        }
    }
}
