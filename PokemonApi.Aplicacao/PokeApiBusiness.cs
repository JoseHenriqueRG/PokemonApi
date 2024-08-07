using PokemonApi.Domain.Interfaces;
using PokemonApi.Domain.ViewModels;

namespace PokemonApi.Business
{
    public class PokeApiBusiness : IPokeApiBusiness
    {
        private readonly IPokeApi _pokeApi;

        public PokeApiBusiness(IPokeApi pokeApi)
        {
            _pokeApi = pokeApi;
        }

        public async Task<ActionResult<PokemonDetailsViewModel>> GetDetailsPokemon(int id)
        {
            var result = await _pokeApi.GetDetailsById(id);

            if (result.IsValid)
            {
                var pokemonDetailsView = new PokemonDetailsViewModel()
                {
                    Pokemon = result.Item
                };

                return new ActionResult<PokemonDetailsViewModel> { IsValid = true, Item = pokemonDetailsView, Message = result.Message };
            }

            return new ActionResult<PokemonDetailsViewModel>
            {
                IsValid = false,
                Message = result.Message
            };
        }

        public async Task<ActionResult<PokemonsListViewModel>> ListPokemons(int limit, int offset)
        {
            var result = await _pokeApi.ListPokemons(limit, offset);

            if (result.IsValid)
            {
                var pokemons = result.Item.Results.Select(i => new
                {
                    name = i.Name,
                    url = i.Url,
                });

                List<PokemonsListViewModel> list = [];

                foreach (var pokemon in pokemons)
                {
                    var pokemonDetails = await _pokeApi.GetDetailsByUrl(pokemon.url);

                    list.Add(new PokemonsListViewModel
                    {
                        Id = pokemonDetails.Item.Id,
                        Name = pokemonDetails.Item.Name,
                        BaseExperience = pokemonDetails.Item.BaseExperience,
                        Height = pokemonDetails.Item.Height,
                        Weight = pokemonDetails.Item.Weight,
                        Image = pokemonDetails.Item.Sprites.FrontDefault
                    });
                }

                if (list.Count > 0)
                {
                    return new ActionResult<PokemonsListViewModel> { IsValid = true, Items = list, Message = result.Message };
                }

                result.Message = "Nenhum Pokemon encontrado.";
            }

            return new ActionResult<PokemonsListViewModel>
            {
                IsValid = false,
                Message = result.Message
            };
        }
    }
}
