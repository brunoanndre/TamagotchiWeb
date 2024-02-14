using TamagotchiPokemonWeb.Models.Sprites;

namespace TamagotchiPokemonWeb.Models
{
    public class TamagotchiDetailsResult
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public required List<AbilityDetails> Abilities { get; set; }
        public required Sprite Sprites { get; set; }
    }
}
