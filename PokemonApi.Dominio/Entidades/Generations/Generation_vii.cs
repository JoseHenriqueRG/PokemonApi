using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_vii
    {
        [JsonPropertyName("icons")]
        public Icons Icons { get; set; }
        [JsonPropertyName("ulta-sun-ultra-moon")]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }
}