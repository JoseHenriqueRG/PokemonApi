using System.Text.Json.Serialization;
using PokemonApi.Domain.Entidades.Generations;

namespace PokemonApi.Domain.Entidades
{
    public class Versions
    {
        [JsonPropertyName("generation-i")]
        public Generation_i Generation_i { get; set; }
        [JsonPropertyName("generation-ii")]
        public Generation_ii Generation_ii { get; set; }
        [JsonPropertyName("generation-iii")]
        public Generation_iii Generation_iii { get; set; }
        [JsonPropertyName("generation-iv")]
        public Generation_iv Generation_iv { get; set; }
        [JsonPropertyName("generation-v")]
        public Generation_v Generation_v { get; set; }
        [JsonPropertyName("generation-vi")]
        public Generation_vi Generation_vi { get; set; }
        [JsonPropertyName("generation-vii")]
        public Generation_vii Generation_vii { get; set; }
        [JsonPropertyName("generation-viii")]
        public Generation_viii Generation_viii { get; set; }
    }
}