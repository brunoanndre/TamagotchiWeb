namespace TamagotchiPokemonWeb.Models
{
    public class TamagotchiSpeciesResult
    {
        public int? Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public required List<TamagotchiResult> Results { get; set; }
    }
}
