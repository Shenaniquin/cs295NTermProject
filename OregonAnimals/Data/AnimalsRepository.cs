using OregonAnimals.Models;
using Microsoft.EntityFrameworkCore;

namespace OregonAnimals.Data
{
    public class AnimalsRepository : IAnimalsRepository
    {
        private ApplicationDbContext context;
        public AnimalsRepository(ApplicationDbContext appDbContext) 
        {
            context = appDbContext;
        }
        public IQueryable<AnimalModel> Animals
        {
            get
            {
                return context.Animals;
            }

        }
        public IQueryable<SightingModel> Sightings
        {
            get
            {
                return context.Sightings.Include(sighting => sighting.AnimalSighted);
            }

        }
        public SightingModel GetSightingByAnimal(string animalName)
        {
            var sighting = context.Sightings
              .Include(sighting => sighting.AnimalSighted)
              .Where(sighting => sighting.AnimalSighted.Animal == animalName)//page seach index
              .SingleOrDefault();
            return sighting;
        }

        public int StoreSighting(SightingModel model)
        {
            model.SightingDate = DateTime.Now;
            context.Sightings.Add(model);
            return context.SaveChanges();
            // returns a positive value if succussful
        }
    }
}
