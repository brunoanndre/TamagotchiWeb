using Newtonsoft.Json;
using RestSharp;
using TamagotchiPokemonWeb.Models;

namespace Tamagotchi.Service
{
    public class PokemonApiService
    {   
        
        public async Task<List<TamagotchiResult>> ObterEspeciesDisponiveis()
        {
            var client = new RestClient("https://pokeapi.co");
            var request = new RestRequest("/api/v2/pokemon", Method.Get);
            var response = await client.ExecuteAsync(request);
            
            var tamagotchiSpecies =  JsonConvert.DeserializeObject<TamagotchiSpeciesResult>(response.Content);
            return tamagotchiSpecies.Results;
        }

        public TamagotchiDetailsResult ObterDetalhesDaEspecie(string Name)
        {
            var client = new RestClient("https://pokeapi.co");
            var request = new RestRequest($"/api/v2/pokemon/{Name}", Method.Get);
            var response =  client.Execute(request);
            return JsonConvert.DeserializeObject<TamagotchiDetailsResult>(response.Content);
        }
    }
}
