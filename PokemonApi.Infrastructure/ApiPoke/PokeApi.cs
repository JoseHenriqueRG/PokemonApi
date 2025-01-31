﻿using Microsoft.Extensions.Caching.Distributed;
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

        private readonly IDistributedCache _distributedCache;
        private readonly HttpClient _client;

        public PokeApi(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;

            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/")
            };
        }

        public async Task<ActionResult<Ability>> GetDetailsAbility(string name)
        {
            try
            {
                var response = await _client.GetAsync($"ability/{name}");

                if (response.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await response.Content.ReadAsStreamAsync();

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
                var response = await _client.GetAsync($"ability/{id}");

                if (response.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await response.Content.ReadAsStreamAsync();

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
                var response = await _client.GetAsync($"pokemon/{id}");

                if (response.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await response.Content.ReadAsStreamAsync();

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
                var response = await _client.GetAsync($"pokemon/{name}");

                if (response.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await response.Content.ReadAsStreamAsync();

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
            Pokemon pokemon;
            string cacheKey = url;

            var pokemonJson = await _distributedCache.GetStringAsync(cacheKey);

            if (!string.IsNullOrWhiteSpace(pokemonJson))
            {
                pokemon = JsonSerializer.Deserialize<Pokemon>(pokemonJson);

                return new ActionResult<Pokemon>() { IsValid = true, Message = "Pokemon carregado com sucesso.", Item = pokemon };
            }

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    pokemon = JsonSerializer.Deserialize<Pokemon>(result);

                    var memoryCacheEntryOptions = new DistributedCacheEntryOptions()
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1),
                        SlidingExpiration = TimeSpan.FromDays(1),
                    };

                    await _distributedCache.SetStringAsync(cacheKey, result, memoryCacheEntryOptions);

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
                var response = await _client.GetAsync($"pokemon?limit={limit}&offset={offset}");

                if (response.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await response.Content.ReadAsStreamAsync();

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
