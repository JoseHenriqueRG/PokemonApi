using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class Other
    {
        [JsonPropertyName("dream_world")]
        public DreamWorld DreamWorld { get; set; }
        [JsonPropertyName("home")]
        public Home Home { get; set; }
        [JsonPropertyName("official_artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
        [JsonPropertyName("showdown")]
        public Showdown Showdown { get; set; }
    }
}