using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_ii
    {
        [JsonPropertyName("crystal")]
        public Crystal Crystal { get; set; }
        [JsonPropertyName("gold")]
        public Gold Gold { get; set; }
        [JsonPropertyName("silver")]
        public Silver Silver { get; set; }
    }
}