using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Generation_vi
    {
        [JsonPropertyName("omegaruby_alphasapphire")]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }
        [JsonPropertyName("x-y")]
        public XY XY { get; set; }
    }
}