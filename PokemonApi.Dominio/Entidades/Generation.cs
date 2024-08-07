﻿using System.Text.Json.Serialization;

namespace PokemonApi.Domain.Entidades
{
    public class Generation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}