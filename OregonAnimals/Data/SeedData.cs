using OregonAnimals.Models;
using System;
using System.Xml.Linq;

namespace OregonAnimals.Data
{
    public class SeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Animals.Any())  // this is to prevent adding duplicate data
            {
                AnimalModel animal = new AnimalModel
                {
                    Animal = "Beaver",
                    AnimalImage = "https://www.shutterstock.com/image-photo/beaver-forest-eating-closeup-600w-111809165.jpg",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                SightingModel sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum= 2,
                    Location = "Beaver Creek",
                    SightingDate = DateTime.Parse("01/11/18"),
                    UserName = "Yogi"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Couger",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 1,
                    Location = "Beaver Creek",
                    SightingDate = DateTime.Parse("06/16/21"),
                    UserName = "Yogi"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Elk",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 12,
                    Location = "Beaver Creek",
                    SightingDate = DateTime.Parse("05/24/20"),
                    UserName = "BullWinkle"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Skunk",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 1,
                    Location = "Fern Ridge",
                    SightingDate = DateTime.Parse("12/21/21"),
                    UserName = "Yogi"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Deer",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 2,
                    Location = "Fall Creek",
                    SightingDate = DateTime.Parse("03/27/19"),
                    UserName = "Yogi"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Opossum",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 2,
                    Location = "Fern Ridge",
                    SightingDate = DateTime.Parse("01/09/20"),
                    UserName = "BullWinkle"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Racoon",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);

                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 4,
                    Location = "Dorena Lake",
                    SightingDate = DateTime.Parse("07/27/20"),
                    UserName = "BigFoot"
                };
                context.Sightings.Add(sighting);

                animal = new AnimalModel
                {
                    Animal = "Black Bear",
                    AnimalImage = "",
                    Description = "Encounter",
                };
                context.Animals.Add(animal);


                sighting = new SightingModel
                {
                    AnimalSighted = animal,
                    AnimalNum = 1,
                    Location = "Mt. June",
                    SightingDate = DateTime.Parse("09/02/21"),
                    UserName = "BigFoot"
                };
                context.Sightings.Add(sighting);

                context.SaveChanges();
            }
        }
    }
}
