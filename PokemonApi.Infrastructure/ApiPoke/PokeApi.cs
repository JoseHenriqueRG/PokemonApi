using PokemonApi.Domain.Entidades;
using PokemonApi.Domain.Interfaces;
using PokemonApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonApi.Infrastructure.ApiPoke
{
    public class PokeApi : IPokeApi
    {
        private readonly HttpClient _client;

        public PokeApi()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/")
            };
        }

        public async Task<ActionResult<Ability>> GetDetailsAbility(string name)
        {
            try
            {
                var httpResponseMessage = await _client.GetAsync($"ability/{name}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var ability = await JsonSerializer.DeserializeAsync<Ability>(contentStream);

                    return new ActionResult<Ability>() { IsValid = true, Message = "Detalhes carregado com sucesso.", Item = ability };
                }

                return new ActionResult<Ability>() { IsValid = false, Message = "Habilidade não encontrada." };
            }
            catch (Exception ex)
            {
                return new ActionResult<Ability>() { IsValid = false, Message = ex.Message };
            }
        }

        public async Task<ActionResult<Ability>> GetDetailsAbility(int id)
        {
            try
            {
                var httpResponseMessage = await _client.GetAsync($"ability/{id}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var ability = await JsonSerializer.DeserializeAsync<Ability>(contentStream);

                    return new ActionResult<Ability>() { IsValid = true, Message = "Detalhes carregado com sucesso.", Item = ability };
                }

                return new ActionResult<Ability>() { IsValid = false, Message = "Habilidade não encontrada." };
            }
            catch (Exception ex)
            {
                return new ActionResult<Ability>() { IsValid = false, Message = ex.Message };
            }
        }

        public async Task<ActionResult<Pokemon>> GetDetailsById(int id)
        {
            try
            {
                var httpResponseMessage = await _client.GetAsync($"pokemon/{id}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(contentStream);

                    return new ActionResult<Pokemon>() { IsValid = true, Message = "Pokemon carregado com sucesso.", Item = pokemon };
                }

                return new ActionResult<Pokemon>() { IsValid = false, Message = "Pokemon não encontrado." };
            }
            catch (Exception ex)
            {
                return new ActionResult<Pokemon>() { IsValid = false, Message = ex.Message };
            }
        }

        public async Task<ActionResult<Pokemon>> GetDetailsByName(string name)
        {
            try
            {
                var httpResponseMessage = await _client.GetAsync($"pokemon/{name}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(contentStream);

                    return new ActionResult<Pokemon>() { IsValid = true, Message = "Pokemon carregado com sucesso.", Item = pokemon };
                }

                return new ActionResult<Pokemon>() { IsValid = false, Message = "Pokemon não encontrado." };
            }
            catch (Exception ex)
            {
                return new ActionResult<Pokemon>() { IsValid = false, Message = ex.Message };
            }
        }

        public async Task<ActionResult<Pokemon>> GetDetailsByUrl(string url)
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                var httpResponseMessage = await _client.SendAsync(httpRequestMessage);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var contentStr =
                        await httpResponseMessage.Content.ReadAsStringAsync();

                    var pokemon = await JsonSerializer.DeserializeAsync<Pokemon>(contentStream);

                    return new ActionResult<Pokemon>() { IsValid = true, Message = "Pokemon carregado com sucesso.", Item = pokemon };
                }

                return new ActionResult<Pokemon>() { IsValid = false, Message = "Pokemon não encontrado." };
            }
            catch (Exception ex)
            {
                return new ActionResult<Pokemon>() { IsValid = false, Message = ex.Message };
            }
        }

        public async Task<ActionResult<PokemonList>> ListPokemons(int limit, int offset)
        {
            try
            {
                var httpResponseMessage = await _client.GetAsync($"pokemon?limit={limit}&offset={offset}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();

                    var pokemons = await JsonSerializer.DeserializeAsync<PokemonList>(contentStream);

                    return new ActionResult<PokemonList>() { IsValid = true, Message = "Lista carregada com sucesso.", Item = pokemons };
                }

                return new ActionResult<PokemonList>() { IsValid = false, Message = "Lista não encontrada." };
            }
            catch (Exception ex)
            {
                return new ActionResult<PokemonList>() { IsValid = false, Message = ex.Message };
            }
        }
    }
}
