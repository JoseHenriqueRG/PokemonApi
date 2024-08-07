using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }
}