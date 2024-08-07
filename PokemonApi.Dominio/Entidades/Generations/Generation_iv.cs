using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_iv
    {
        [JsonPropertyName("diamond_pearl")]
        public DiamondPearl DiamondPearl { get; set; }
        [JsonPropertyName("heartgold_soulsilver")]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
        [JsonPropertyName("platinum")]
        public Platinum Platinum { get; set; }
    }
}