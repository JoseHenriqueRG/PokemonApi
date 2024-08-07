using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonPastType
    {
        [JsonPropertyName("generation")]
        public Generation Generation { get; set; }
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }
    }
}