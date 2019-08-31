using System.ComponentModel.DataAnnotations;

namespace AdapterDesingPattern.Models
{
    public class Main
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
