using Microsoft.EntityFrameworkCore;
using OregonAnimals.Models;

namespace OregonAnimals
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<AnimalModel> Animals { get; set; }
        public DbSet<SightingModel> Sightings { get; set; }
    }
}
