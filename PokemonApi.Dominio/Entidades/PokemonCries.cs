using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonCries
    {
        [JsonPropertyName("latest")]
        public string Latest { get; set; }
        [JsonPropertyName("legacy")]
        public string Legacy { get; set; }
    }
}