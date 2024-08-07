using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonHeldItem
    {
        [JsonPropertyName("item")]
        public Item Item { get; set; }
        [JsonPropertyName("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }
}