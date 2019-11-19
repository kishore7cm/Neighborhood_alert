using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeighbourhoodLocation
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Neighbourhood
    {
        private long objectid;
        private double cagisCincCommunityCouncilBndArea;
        private double perimeter;
        private long neighBnd;
        private string neigh;
        private long symbol;
        private long line;
        private long symbol1;
        private double acres;
        private NeighBoun neighBoun;
        private long revisedDa;
        private long shapearea;
        private long shapelen;

        [JsonProperty("OBJECTID")]
        public long Objectid { get => objectid; set => objectid = value; }

        [JsonProperty("CAGISCinc_Community_Council_BndAREA")]
        public double CagisCincCommunityCouncilBndArea { get => cagisCincCommunityCouncilBndArea; set => cagisCincCommunityCouncilBndArea = value; }

        [JsonProperty("PERIMETER")]
        public double Perimeter { get => perimeter; set => perimeter = value; }

        [JsonProperty("NEIGH_BND_")]
        public long NeighBnd { get => neighBnd; set => neighBnd = value; }

        [JsonProperty("NEIGH")]
        public string Neigh { get => neigh; set => neigh = value; }

        [JsonProperty("SYMBOL")]
        public long Symbol { get => symbol; set => symbol = value; }

        [JsonProperty("LINE")]
        public long Line { get => line; set => line = value; }

        [JsonProperty("SYMBOL1")]
        public long Symbol1 { get => symbol1; set => symbol1 = value; }

        [JsonProperty("ACRES")]
        public double Acres { get => acres; set => acres = value; }

        [JsonProperty("NEIGH_BOUN")]
        public NeighBoun NeighBoun { get => neighBoun; set => neighBoun = value; }

        [JsonProperty("REVISED_DA")]
        public long RevisedDa { get => revisedDa; set => revisedDa = value; }

        [JsonProperty("SHAPEAREA")]
        public long Shapearea { get => shapearea; set => shapearea = value; }

        [JsonProperty("SHAPELEN")]
        public long Shapelen { get => shapelen; set => shapelen = value; }
    }

    public enum NeighBoun { CommunityCouncilBndy, ContestedArea };

    public partial class Neighbourhood
    {
        public static Neighbourhood[] FromJson(string json) => JsonConvert.DeserializeObject<Neighbourhood[]>(json, NeighbourhoodLocation.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Neighbourhood[] self) => JsonConvert.SerializeObject(self, NeighbourhoodLocation.Converter.Settings);
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

