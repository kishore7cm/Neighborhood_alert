﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using NeighborhoodLocation;
//
//    var neighborhood = Neighborhood.FromJson(jsonString);

namespace NeighborhoodLocation
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Neighborhood
    {
        [JsonProperty("displayFieldName")]
        public string DisplayFieldName { get; set; }

        [JsonProperty("fieldAliases")]
        public FieldAliases FieldAliases { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }

    public partial class Feature
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("OBJECTID")]
        public long Objectid { get; set; }

        [JsonProperty("CAGIS.Cinc_Community_Council_Bnd.AREA")]
        public double CagisCincCommunityCouncilBndArea { get; set; }

        [JsonProperty("PERIMETER")]
        public double Perimeter { get; set; }

        [JsonProperty("NEIGH_BND_")]
        public long NeighBnd { get; set; }

        [JsonProperty("NEIGH")]
        public string Neigh { get; set; }

        [JsonProperty("LINE")]
        public long Line { get; set; }

        [JsonProperty("ACRES")]
        public double Acres { get; set; }

        [JsonProperty("NEIGH_BOUN")]
        public NeighBoun NeighBoun { get; set; }

        [JsonProperty("REVISED_DA")]
        public long RevisedDa { get; set; }
    }

    public partial class FieldAliases
    {
        [JsonProperty("OBJECTID")]
        public string Objectid { get; set; }

        [JsonProperty("CAGIS.Cinc_Community_Council_Bnd.AREA")]
        public string CagisCincCommunityCouncilBndArea { get; set; }

        [JsonProperty("PERIMETER")]
        public string Perimeter { get; set; }

        [JsonProperty("NEIGH_BND_")]
        public string NeighBnd { get; set; }

        [JsonProperty("NEIGH")]
        public string Neigh { get; set; }

        [JsonProperty("LINE")]
        public string Line { get; set; }

        [JsonProperty("ACRES")]
        public string Acres { get; set; }

        [JsonProperty("NEIGH_BOUN")]
        public string NeighBoun { get; set; }

        [JsonProperty("REVISED_DA")]
        public string RevisedDa { get; set; }
    }

    public partial class Field
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }
    }

    public enum NeighBoun { CommunityCouncilBndy, ContestedArea };

    public partial class Neighborhood
    {
        public static Neighborhood[] FromJson(string json) => JsonConvert.DeserializeObject<Neighborhood[]>(json, NeighborhoodLocation.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Neighborhood[] self) => JsonConvert.SerializeObject(self, NeighborhoodLocation.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                NeighBounConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class NeighBounConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NeighBoun) || t == typeof(NeighBoun?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Community Council Bndy":
                    return NeighBoun.CommunityCouncilBndy;
                case "Contested Area":
                    return NeighBoun.ContestedArea;
            }
            throw new Exception("Cannot unmarshal type NeighBoun");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NeighBoun)untypedValue;
            switch (value)
            {
                case NeighBoun.CommunityCouncilBndy:
                    serializer.Serialize(writer, "Community Council Bndy");
                    return;
                case NeighBoun.ContestedArea:
                    serializer.Serialize(writer, "Contested Area");
                    return;
            }
            throw new Exception("Cannot marshal type NeighBoun");
        }

        public static readonly NeighBounConverter Singleton = new NeighBounConverter();
    }
}
