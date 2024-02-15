namespace TamagotchiPokemonWeb.Models
{
    public class AbilityDetails
    {
        public required Ability Ability { get; set; }
        public string? Is_hidden { get; set; }
        public int? Slot { get; set; }
    }
}
