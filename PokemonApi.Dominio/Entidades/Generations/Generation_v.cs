using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_v
    {
        [JsonPropertyName("black_white")]
        public BlackWhite BlackWhite { get; set; }
    }
}