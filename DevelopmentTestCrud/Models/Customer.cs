using System.ComponentModel.DataAnnotations;

namespace DevelopmentTestCrud.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string GeoState { get; set; }
    }
}
