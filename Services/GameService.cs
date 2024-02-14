using Tamagotchi.Service;
using TamagotchiPokemonWeb.Models;

namespace TamagotchiPokemonWeb.Services
{
    public class GameService
    {
        private  PokemonApiService _pokemonApiService = new();
        public List<TamagotchiDetailsResult> _tamagotchiDetailsResult= [];
        private List<TamagotchiResult> tamagotchiSpecies {get; set;}
        public List<TamagotchiDTO> AdoptedsTamagotchis { get;} = [];

        public  List<TamagotchiDetailsResult> FindAllSpecies()
        {
            if (tamagotchiSpecies == null)
            {
                tamagotchiSpecies = _pokemonApiService.ObterEspeciesDisponiveis().Result;

                for (int i = 0; i < tamagotchiSpecies.Count; i++)
                {
                    var DetailsResult = FindSpecieDetail(tamagotchiSpecies[i].Name);
                    _tamagotchiDetailsResult.Add(DetailsResult);
                }
            }

            return _tamagotchiDetailsResult;
        }

        public TamagotchiDetailsResult FindSpecieDetail(string name)
        {
            var tamagotchiDetailResult =  _pokemonApiService.ObterDetalhesDaEspecie(name);
            return tamagotchiDetailResult;
        }

        public void AdoptTamagotchi(string name)
        {
            var tamagotchiToAdopt = _pokemonApiService.ObterDetalhesDaEspecie(name);
            var rand = new Random();
            TamagotchiDTO tamagotchi = new TamagotchiDTO
            {
                Id = tamagotchiToAdopt.Id,
                Name = tamagotchiToAdopt.Name,
                Height = tamagotchiToAdopt.Height,
                Weight = tamagotchiToAdopt.Weight,
                Sprites = tamagotchiToAdopt.Sprites,
                Abilities = tamagotchiToAdopt.Abilities,
                Humor = rand.Next(11),
                Hanger = rand.Next(11),
                Health = rand.Next(11)
            };
            AdoptedsTamagotchis.Add(tamagotchi);
        }


        public void FeedTamagotchi(TamagotchiDTO tamagotchi)
        {
            tamagotchi.Feed();
        }

        public void RestTamagotchi(TamagotchiDTO tamagotchi)
        {
            tamagotchi.Rest();
        }

        public void PlayWithTamagotchi(TamagotchiDTO tamagotchi)
        {
            tamagotchi.Play();
        }

        public void PetTamagotchi(TamagotchiDTO tamagotchi)
        {
            tamagotchi.Pet();
        }

        public TamagotchiDTO FindById(int id)
        {
            return AdoptedsTamagotchis.Find(tmgc => tmgc.Id == id);
        }
    }
}
