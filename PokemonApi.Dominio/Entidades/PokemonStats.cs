using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonStats
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
        [JsonPropertyName("effort")]
        public int Effort { get; set; }
        [JsonPropertyName("stat")]
        public Stat Stat { get; set; }
    }
}