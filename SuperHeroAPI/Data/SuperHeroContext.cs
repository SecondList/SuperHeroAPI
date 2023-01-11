using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Data
{
    public class SuperHeroContext :DbContext
    {
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeros { get; set; }
    }
}
