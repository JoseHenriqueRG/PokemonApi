using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_i
    {
        [JsonPropertyName("red_blue")]
        public RedBlue RedBlue { get; set; }
        [JsonPropertyName("yellow")]
        public Yellow Yellow { get; set; }
    }
}