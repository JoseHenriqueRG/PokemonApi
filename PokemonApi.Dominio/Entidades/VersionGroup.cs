using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class VersionGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}