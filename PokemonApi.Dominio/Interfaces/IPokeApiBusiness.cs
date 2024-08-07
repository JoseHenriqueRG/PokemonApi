using PokemonApi.Domain.ViewModels;

namespace PokemonApi.Domain.Interfaces
{
    public interface IPokeApiBusiness
    {
        Task<ActionResult<PokemonsListViewModel>> ListPokemons(int limit, int offset);
        Task<ActionResult<PokemonDetailsViewModel>> GetDetailsPokemon(int id);
    }
}
