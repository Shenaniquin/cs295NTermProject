using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OregonAnimals.Models
{
    public class AnimalModel
    {
        [Key]
        public string Animal { get; set; }
        public string Description { get; set; }
        public string AnimalImage { get; set; }
    }
}
