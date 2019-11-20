﻿namespace Neighbourhood
    
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NeighbourhoodAlert
    {
        private long objectid;
        private double cagisCincCommunityCouncilBndArea;

        [JsonProperty("OBJECTID")]
        public long Objectid { get => objectid; set => objectid = value; }

        [JsonProperty("CAGISCinc_Community_Council_BndAREA")]
        public double CagisCincCommunityCouncilBndArea { get => cagisCincCommunityCouncilBndArea; set => cagisCincCommunityCouncilBndArea = value; }

        [JsonProperty("PERIMETER")]
        public double Perimeter { get; set; }

        [JsonProperty("NEIGH_BND_")]
        public long NeighBnd { get; set; }

        [JsonProperty("NEIGH")]
        public string Neigh { get; set; }

        [JsonProperty("SYMBOL")]
        public long Symbol { get; set; }

        [JsonProperty("LINE")]
        public long Line { get; set; }

        [JsonProperty("SYMBOL1")]
        public long Symbol1 { get; set; }

        [JsonProperty("ACRES")]
        public double Acres { get; set; }

        [JsonProperty("NEIGH_BOUN")]
        public NeighBoun NeighBoun { get; set; }

        [JsonProperty("REVISED_DA")]
        public long RevisedDa { get; set; }

        [JsonProperty("SHAPEAREA")]
        public long Shapearea { get; set; }

        [JsonProperty("SHAPELEN")]
        public long Shapelen { get; set; }
    }

    public enum NeighBoun { CommunityCouncilBndy, ContestedArea };

    public partial class NeighbourhoodAlert
    {
        public static NeighbourhoodAlert[] FromJson(string json) => JsonConvert.DeserializeObject<NeighbourhoodAlert[]>(json, Neighbourhood.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NeighbourhoodAlert[] self) => JsonConvert.SerializeObject(self, Neighbourhood.Converter.Settings);
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
