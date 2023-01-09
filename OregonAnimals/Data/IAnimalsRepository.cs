using OregonAnimals.Models;

namespace OregonAnimals.Data
{
    public interface IAnimalsRepository
    {
        public SightingModel GetSightingByAnimal(string animalName);
        public int StoreSighting(SightingModel model);
        public IQueryable<AnimalModel> Animals { get; }
        public IQueryable<SightingModel> Sightings { get; }
    }
}