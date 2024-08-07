using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Icons
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string? FrontFemale { get; set; }
    }
}