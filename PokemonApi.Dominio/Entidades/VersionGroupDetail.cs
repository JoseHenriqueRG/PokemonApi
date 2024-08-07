using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class VersionGroupDetail
    {
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }
    }
}