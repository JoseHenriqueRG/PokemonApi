using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class VersionDetail
    {
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }
        [JsonPropertyName("version")]
        public Version Version { get; set; }
    }
}