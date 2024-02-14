using AutoMapper;
using TamagotchiPokemonWeb.Models;

namespace TamagotchiPokemonWeb.Services
{
    public class AutoMapperTamagotchi : Profile
    {
        public AutoMapperTamagotchi() 
        {
            CreateMap<TamagotchiDetailsResult, TamagotchiDTO>();  
        }  
    }
}
