using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

    }
}
