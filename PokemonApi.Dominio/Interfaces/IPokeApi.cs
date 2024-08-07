using PokemonApi.Domain.Entidades;
using PokemonApi.Domain.ViewModels;

namespace PokemonApi.Domain.Interfaces
{
    public interface IPokeApi
    {
        Task<ActionResult<PokemonList>> ListPokemons(int limit, int offset);
        Task<ActionResult<Pokemon>> GetDetailsByUrl(string url);
        Task<ActionResult<Pokemon>> GetDetailsByName(string name);
        Task<ActionResult<Pokemon>> GetDetailsById(int id);
        Task<ActionResult<Ability>> GetDetailsAbility(string name);
        Task<ActionResult<Ability>> GetDetailsAbility(int id);
    }
}
