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
        public int Hanger { get; set; }
        public int Health { get; set; }
        public required List<AbilityDetails> Abilities { get; set; }
        public required Sprite Sprites { get; set; }

        public void Feed()
        {
            Hanger = Math.Min(Hanger + 2, 10);
            Health = Math.Max(Health - 1, 0);
        }
 
        public void Play()
        {
            Humor = Math.Min(Humor + 2, 10);
            Health = Math.Max(Health -1, 0);
            Hanger = Math.Max(Hanger -1, 0);
        }
        public void Rest()
        {
            Health = Math.Min(Health + 2, 10);
            Humor  = Math.Max(Humor - 1, 0);
            Hanger = Math.Max(Hanger - 1, 0);
        }
        public void Pet()
        {
            Humor = Math.Min(Humor + 2, 10);
            Health = Math.Min(Health + 1,10);
        }
    }
}
