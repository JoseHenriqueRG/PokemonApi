using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonType
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        [JsonPropertyName("type")]
        public Type Type { get; set; }
    }
}