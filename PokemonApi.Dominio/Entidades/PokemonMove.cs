using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonMove
    {
        [JsonPropertyName("move")]
        public Move Move { get; set; }
        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}