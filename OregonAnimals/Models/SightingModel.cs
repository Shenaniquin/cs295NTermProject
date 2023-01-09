using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OregonAnimals.Models
{
    public class SightingModel
    {
        [Key]
        public int SightingID { get; set; }
        public AnimalModel AnimalSighted { get; set; }
        public int AnimalNum { get; set; }
        public string Location { get; set; }
        public DateTime SightingDate { get; set; }
        public string UserName { get; set; }
    }
}
