using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_viii
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }
    }
}