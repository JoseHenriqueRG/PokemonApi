using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class RedBlue
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_gray")]
        public string BackGray { get; set; }
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_gray")]
        public string FrontGray { get; set; }
    }
}