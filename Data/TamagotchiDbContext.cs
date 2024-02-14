using TamagotchiPokemonWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace TamagotchiPokemonWeb.Data
{
    public class TamagotchiDbContext : DbContext
    {

        public TamagotchiDbContext(DbContextOptions<TamagotchiDbContext> options) : base(options) { }
    }

//    public DbSet<TamagotchiPokemonWeb.Models.Pet> Tamagotchi { get; set; }
   
}
