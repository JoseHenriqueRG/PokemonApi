﻿using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class UltraSunUltraMoon
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_female")]
        public string? FrontFemale { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("front_shiny_female")]
        public string? FrontShinyFemale { get; set; }
    }
}