using System.ComponentModel.DataAnnotations;

namespace LabaryApi.Modele
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Aouthor { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
        [MaxLength(50)]
        [Required]
        public string Body { get; set; }
        [MaxLength(250)]
        [Required]
        public string Description { get; set; }
    }
}
