using System.Runtime.ExceptionServices;
using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_iii
    {
        [JsonPropertyName("emerald")]
        public Emerald Emerald { get; set; }
        [JsonPropertyName("firered_leafgreen")]
        public FireredLeafgreen FireredLeafgreen { get; set; }
        [JsonPropertyName("ruby_sapphire")]
        public RubySapphire RubySapphire { get; set; }
    }
}