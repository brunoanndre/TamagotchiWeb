using TamagotchiPokemonWeb.Models.Sprites;

namespace TamagotchiPokemonWeb.Models
{
    public class TamagotchiDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Humor { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
        public required List<AbilityDetails> Abilities { get; set; }
        public required Sprite Sprites { get; set; }

        public void Feed()
        {
            Hunger = Math.Min(Hunger + 2, 10);
            Health = Math.Max(Health - 1, 0);
        }
 
        public void Play()
        {
            Humor = Math.Min(Humor + 2, 10);
            Health = Math.Max(Health -1, 0);
            Hunger = Math.Max(Hunger - 1, 0);
        }
        public void Rest()
        {
            Health = Math.Min(Health + 2, 10);
            Humor  = Math.Max(Humor - 1, 0);
            Hunger = Math.Max(Hunger - 1, 0);
        }
        public void Pet()
        {
            Humor = Math.Min(Humor + 2, 10);
        }
    }
}
