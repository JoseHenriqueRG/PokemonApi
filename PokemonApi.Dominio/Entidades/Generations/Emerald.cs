﻿using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades.Generations
{
    public class Emerald
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
    }
}