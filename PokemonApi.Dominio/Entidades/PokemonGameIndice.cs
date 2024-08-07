using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class PokemonGameIndice
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }
        [JsonPropertyName("version")]
        public Version Version { get; set; }
    }
}