﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeighbourhoodCrime

{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Crime

    {
        private string instanceid;
        private string incidentNo;
        private DateTimeOffset dateReported;
        private DateTimeOffset dateFrom;
        private DateTimeOffset dateTo;
        private Clsd? clsd;
        private long ucr;
        private DstUnion dst;
        private long? beat;
        private string offense;
        private string location;
        private TheftCode? theftCode;
        private HateBias hateBias;
        private Dayofweek? dayofweek;
        private long? rptArea;
        private string cpdNeighborhood;
        private string neighborhood;
        private Weapons weapons;
        private DateTimeOffset? dateOfClearance;
        private string hourFrom;
        private string hourTo;
        private string addressX;
        private string longitudeX;
        private string latitudeX;
        private Age victimAge;
        private Race? victimRace;
        private Ethnicity? victimEthnicity;
        private VictimGender? victimGender;
        private Age suspectAge;
        private Race? suspectRace;
        private Ethnicity? suspectEthnicity;
        private SuspectGender? suspectGender;
        private long totalnumbervictims;
        private long? totalsuspects;
        private UcrGroup ucrGroup;
        private string communityCouncilNeighborhood;
        private long zip;
        private Floor? floor;
        private Side? side;
        private Opening? opening;

        [JsonProperty("instanceid")]
        public string Instanceid { get => instanceid; set => instanceid = value; }

        [JsonProperty("incident_no")]
        public string IncidentNo { get => incidentNo; set => incidentNo = value; }

        [JsonProperty("date_reported")]
        public DateTimeOffset DateReported { get => dateReported; set => dateReported = value; }

        [JsonProperty("date_from")]
        public DateTimeOffset DateFrom { get => dateFrom; set => dateFrom = value; }

        [JsonProperty("date_to")]
        public DateTimeOffset DateTo { get => dateTo; set => dateTo = value; }

        [JsonProperty("clsd", NullValueHandling = NullValueHandling.Ignore)]
        public Clsd? Clsd { get => clsd; set => clsd = value; }

        [JsonProperty("ucr")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Ucr { get => ucr; set => ucr = value; }

        [JsonProperty("dst")]
        public DstUnion Dst { get => dst; set => dst = value; }

        [JsonProperty("beat", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Beat { get => beat; set => beat = value; }

        [JsonProperty("offense")]
        public string Offense { get => offense; set => offense = value; }

        [JsonProperty("location")]
        public string Location { get => location; set => location = value; }

        [JsonProperty("theft_code", NullValueHandling = NullValueHandling.Ignore)]
        public TheftCode? TheftCode { get => theftCode; set => theftCode = value; }

        [JsonProperty("hate_bias")]
        public HateBias HateBias { get => hateBias; set => hateBias = value; }

        [JsonProperty("dayofweek", NullValueHandling = NullValueHandling.Ignore)]
        public Dayofweek? Dayofweek { get => dayofweek; set => dayofweek = value; }

        [JsonProperty("rpt_area", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? RptArea { get => rptArea; set => rptArea = value; }

        [JsonProperty("cpd_neighborhood", NullValueHandling = NullValueHandling.Ignore)]
        public string CpdNeighborhood { get => cpdNeighborhood; set => cpdNeighborhood = value; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get => neighborhood; set => neighborhood = value; }

        [JsonProperty("weapons")]
        public Weapons Weapons { get => weapons; set => weapons = value; }

        [JsonProperty("date_of_clearance", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfClearance { get => dateOfClearance; set => dateOfClearance = value; }

        [JsonProperty("hour_from")]
        public string HourFrom { get => hourFrom; set => hourFrom = value; }

        [JsonProperty("hour_to")]
        public string HourTo { get => hourTo; set => hourTo = value; }

        [JsonProperty("address_x", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressX { get => addressX; set => addressX = value; }

        [JsonProperty("longitude_x", NullValueHandling = NullValueHandling.Ignore)]
        public string LongitudeX { get => longitudeX; set => longitudeX = value; }

        [JsonProperty("latitude_x", NullValueHandling = NullValueHandling.Ignore)]
        public string LatitudeX { get => latitudeX; set => latitudeX = value; }

        [JsonProperty("victim_age")]
        public Age VictimAge { get => victimAge; set => victimAge = value; }

        [JsonProperty("victim_race", NullValueHandling = NullValueHandling.Ignore)]
        public Race? VictimRace { get => victimRace; set => victimRace = value; }

        [JsonProperty("victim_ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public Ethnicity? VictimEthnicity { get => victimEthnicity; set => victimEthnicity = value; }

        [JsonProperty("victim_gender", NullValueHandling = NullValueHandling.Ignore)]
        public VictimGender? VictimGender { get => victimGender; set => victimGender = value; }

        [JsonProperty("suspect_age")]
        public Age SuspectAge { get => suspectAge; set => suspectAge = value; }

        [JsonProperty("suspect_race", NullValueHandling = NullValueHandling.Ignore)]
        public Race? SuspectRace { get => suspectRace; set => suspectRace = value; }

        [JsonProperty("suspect_ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public Ethnicity? SuspectEthnicity { get => suspectEthnicity; set => suspectEthnicity = value; }

        [JsonProperty("suspect_gender", NullValueHandling = NullValueHandling.Ignore)]
        public SuspectGender? SuspectGender { get => suspectGender; set => suspectGender = value; }

        [JsonProperty("totalnumbervictims")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Totalnumbervictims { get => totalnumbervictims; set => totalnumbervictims = value; }

        [JsonProperty("totalsuspects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Totalsuspects { get => totalsuspects; set => totalsuspects = value; }

        [JsonProperty("ucr_group")]
        public UcrGroup UcrGroup { get => ucrGroup; set => ucrGroup = value; }

        [JsonProperty("community_council_neighborhood")]
        public string CommunityCouncilNeighborhood { get => communityCouncilNeighborhood; set => communityCouncilNeighborhood = value; }

        [JsonProperty("zip")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Zip { get => zip; set => zip = value; }

        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public Floor? Floor { get => floor; set => floor = value; }

        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public Side? Side { get => side; set => side = value; }

        [JsonProperty("opening", NullValueHandling = NullValueHandling.Ignore)]
        public Opening? Opening { get => opening; set => opening = value; }
    }

    public enum Clsd { ADeathOfOffender, BProsecutionDeclined, DVictimRefusedToCooperate, EJuvenileNoCustody, FClearedByArrestAdult, GClearedByArrestJuvenile, HWarrantIssued, IInvestigationPending, JClosed, KUnfounded, ZEarlyClosed };

    public enum Dayofweek { Friday, Monday, Saturday, Sunday, Thursday, Tuesday, Wednesday };

    public enum DstEnum { CentralBusiness };

    public enum Floor { The1Basement, The2FirstFloor, The3SecondFloor, The4Other, The5Unknown };

    public enum HateBias { NNoBiasNotApplicable, The43AntiHomosexualGayAndLesbian, The88DomesticViolence, The89GangRelated };

    public enum Opening { The1Door, The2Window, The3Garage, The6Unknown };

    public enum Side { The1Front, The2Side, The3Rear, The4Roof, The6Unknown };

    public enum Age { Adult18, JuvenileUnder18, Over70, The1825, The2630, The3140, The4150, The5160, The6170, Under18, Unknown };

    public enum Ethnicity { HispanicOrigin, NotOfHispanicOrig, Unknown };

    public enum SuspectGender { Female, Male, Unknown };

    public enum Race { AmericanIndianAlas, AsianPacificIsland, Black, Unknown, White };

    public enum TheftCode { The23BPurseSnatching, The23CShoplifting, The23DTheftFromBuilding, The23FTheftFromMotorVehicle, The23GTheftOfMotorVehiclePartsOrAccessories, The23HAllOtherLarceny, The24ITheftOfLicensePlate, The24OMotorVehicleTheft };

    public enum UcrGroup { AggravatedAssaults, BurglaryBreakingEntering, Homicide, Part2Minor, Rape, Robbery, Theft, UnauthorizedUse };

    public enum VictimGender { Female, MMale, Male };

    public enum Weapons { The11FirearmTypeNotStated, The12AAutomaticHandgun, The12Handgun, The13Rifle, The15OtherFirearm, The18BbAndPelletGuns, The20KnifeCuttingInstrumentIcepickAxEtc, The30BluntObjectClubHammerEtc, The35MotorVehicleWhenUsedAsWeapon, The40PersonalWeaponsHandsFeetTeethEtc, The70DrugsNarcoticsSleepingPills, The80OtherWeapon, The85AsphyxiationByDrowningStrangulationSuffocation, The99None, UUnknown };

    public partial struct DstUnion
    {
        public DstEnum? Enum;
        public long? Integer;

        public static implicit operator DstUnion(DstEnum Enum) => new DstUnion { Enum = Enum };
        public static implicit operator DstUnion(long Integer) => new DstUnion { Integer = Integer };
    }

    public partial class Crime
    {
        public static Crime[] FromJson(string json) => JsonConvert.DeserializeObject<Crime[]>(json, NeighbourhoodCrime.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Crime[] self) => JsonConvert.SerializeObject(self, NeighbourhoodCrime.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ClsdConverter.Singleton,
                DayofweekConverter.Singleton,
                DstUnionConverter.Singleton,
                DstEnumConverter.Singleton,
                FloorConverter.Singleton,
                HateBiasConverter.Singleton,
                OpeningConverter.Singleton,
                SideConverter.Singleton,
                AgeConverter.Singleton,
                EthnicityConverter.Singleton,
                SuspectGenderConverter.Singleton,
                RaceConverter.Singleton,
                TheftCodeConverter.Singleton,
                UcrGroupConverter.Singleton,
                VictimGenderConverter.Singleton,
                WeaponsConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }


    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class ClsdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Clsd) || t == typeof(Clsd?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A--DEATH OF OFFENDER":
                    return Clsd.ADeathOfOffender;
                case "B--PROSECUTION DECLINED":
                    return Clsd.BProsecutionDeclined;
                case "D--VICTIM REFUSED TO COOPERATE":
                    return Clsd.DVictimRefusedToCooperate;
                case "E--JUVENILE/NO CUSTODY":
                    return Clsd.EJuvenileNoCustody;
                case "F--CLEARED BY ARREST - ADULT":
                    return Clsd.FClearedByArrestAdult;
                case "G--CLEARED BY ARREST - JUVENILE":
                    return Clsd.GClearedByArrestJuvenile;
                case "H--WARRANT ISSUED":
                    return Clsd.HWarrantIssued;
                case "I--INVESTIGATION PENDING":
                    return Clsd.IInvestigationPending;
                case "J--CLOSED":
                    return Clsd.JClosed;
                case "K--UNFOUNDED":
                    return Clsd.KUnfounded;
                case "Z--EARLY CLOSED":
                    return Clsd.ZEarlyClosed;
            }
            throw new Exception("Cannot unmarshal type Clsd");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Clsd)untypedValue;
            switch (value)
            {
                case Clsd.ADeathOfOffender:
                    serializer.Serialize(writer, "A--DEATH OF OFFENDER");
                    return;
                case Clsd.BProsecutionDeclined:
                    serializer.Serialize(writer, "B--PROSECUTION DECLINED");
                    return;
                case Clsd.DVictimRefusedToCooperate:
                    serializer.Serialize(writer, "D--VICTIM REFUSED TO COOPERATE");
                    return;
                case Clsd.EJuvenileNoCustody:
                    serializer.Serialize(writer, "E--JUVENILE/NO CUSTODY");
                    return;
                case Clsd.FClearedByArrestAdult:
                    serializer.Serialize(writer, "F--CLEARED BY ARREST - ADULT");
                    return;
                case Clsd.GClearedByArrestJuvenile:
                    serializer.Serialize(writer, "G--CLEARED BY ARREST - JUVENILE");
                    return;
                case Clsd.HWarrantIssued:
                    serializer.Serialize(writer, "H--WARRANT ISSUED");
                    return;
                case Clsd.IInvestigationPending:
                    serializer.Serialize(writer, "I--INVESTIGATION PENDING");
                    return;
                case Clsd.JClosed:
                    serializer.Serialize(writer, "J--CLOSED");
                    return;
                case Clsd.KUnfounded:
                    serializer.Serialize(writer, "K--UNFOUNDED");
                    return;
                case Clsd.ZEarlyClosed:
                    serializer.Serialize(writer, "Z--EARLY CLOSED");
                    return;
            }
            throw new Exception("Cannot marshal type Clsd");
        }

        public static readonly ClsdConverter Singleton = new ClsdConverter();
    }

    internal class DayofweekConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dayofweek) || t == typeof(Dayofweek?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FRIDAY":
                    return Dayofweek.Friday;
                case "MONDAY":
                    return Dayofweek.Monday;
                case "SATURDAY":
                    return Dayofweek.Saturday;
                case "SUNDAY":
                    return Dayofweek.Sunday;
                case "THURSDAY":
                    return Dayofweek.Thursday;
                case "TUESDAY":
                    return Dayofweek.Tuesday;
                case "WEDNESDAY":
                    return Dayofweek.Wednesday;
            }
            throw new Exception("Cannot unmarshal type Dayofweek");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Dayofweek)untypedValue;
            switch (value)
            {
                case Dayofweek.Friday:
                    serializer.Serialize(writer, "FRIDAY");
                    return;
                case Dayofweek.Monday:
                    serializer.Serialize(writer, "MONDAY");
                    return;
                case Dayofweek.Saturday:
                    serializer.Serialize(writer, "SATURDAY");
                    return;
                case Dayofweek.Sunday:
                    serializer.Serialize(writer, "SUNDAY");
                    return;
                case Dayofweek.Thursday:
                    serializer.Serialize(writer, "THURSDAY");
                    return;
                case Dayofweek.Tuesday:
                    serializer.Serialize(writer, "TUESDAY");
                    return;
                case Dayofweek.Wednesday:
                    serializer.Serialize(writer, "WEDNESDAY");
                    return;
            }
            throw new Exception("Cannot marshal type Dayofweek");
        }

        public static readonly DayofweekConverter Singleton = new DayofweekConverter();
    }

    internal class DstUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DstUnion) || t == typeof(DstUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "CENTRAL BUSINESS")
                    {
                        return new DstUnion { Enum = DstEnum.CentralBusiness };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new DstUnion { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type DstUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DstUnion)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == DstEnum.CentralBusiness)
                {
                    serializer.Serialize(writer, "CENTRAL BUSINESS");
                    return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type DstUnion");
        }

        public static readonly DstUnionConverter Singleton = new DstUnionConverter();
    }

    internal class DstEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DstEnum) || t == typeof(DstEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "CENTRAL BUSINESS")
            {
                return DstEnum.CentralBusiness;
            }
            throw new Exception("Cannot unmarshal type DstEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DstEnum)untypedValue;
            if (value == DstEnum.CentralBusiness)
            {
                serializer.Serialize(writer, "CENTRAL BUSINESS");
                return;
            }
            throw new Exception("Cannot marshal type DstEnum");
        }

        public static readonly DstEnumConverter Singleton = new DstEnumConverter();
    }

    internal class FloorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Floor) || t == typeof(Floor?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1 - BASEMENT":
                    return Floor.The1Basement;
                case "2 - FIRST FLOOR":
                    return Floor.The2FirstFloor;
                case "3 - SECOND FLOOR":
                    return Floor.The3SecondFloor;
                case "4 - OTHER":
                    return Floor.The4Other;
                case "5 - UNKNOWN":
                    return Floor.The5Unknown;
            }
            throw new Exception("Cannot unmarshal type Floor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Floor)untypedValue;
            switch (value)
            {
                case Floor.The1Basement:
                    serializer.Serialize(writer, "1 - BASEMENT");
                    return;
                case Floor.The2FirstFloor:
                    serializer.Serialize(writer, "2 - FIRST FLOOR");
                    return;
                case Floor.The3SecondFloor:
                    serializer.Serialize(writer, "3 - SECOND FLOOR");
                    return;
                case Floor.The4Other:
                    serializer.Serialize(writer, "4 - OTHER");
                    return;
                case Floor.The5Unknown:
                    serializer.Serialize(writer, "5 - UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Floor");
        }

        public static readonly FloorConverter Singleton = new FloorConverter();
    }

    internal class HateBiasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HateBias) || t == typeof(HateBias?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "43--ANTI-HOMOSEXUAL (GAY AND LESBIAN)":
                    return HateBias.The43AntiHomosexualGayAndLesbian;
                case "88--DOMESTIC VIOLENCE":
                    return HateBias.The88DomesticViolence;
                case "89--GANG RELATED":
                    return HateBias.The89GangRelated;
                case "N--NO BIAS/NOT APPLICABLE":
                    return HateBias.NNoBiasNotApplicable;
            }
            throw new Exception("Cannot unmarshal type HateBias");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HateBias)untypedValue;
            switch (value)
            {
                case HateBias.The43AntiHomosexualGayAndLesbian:
                    serializer.Serialize(writer, "43--ANTI-HOMOSEXUAL (GAY AND LESBIAN)");
                    return;
                case HateBias.The88DomesticViolence:
                    serializer.Serialize(writer, "88--DOMESTIC VIOLENCE");
                    return;
                case HateBias.The89GangRelated:
                    serializer.Serialize(writer, "89--GANG RELATED");
                    return;
                case HateBias.NNoBiasNotApplicable:
                    serializer.Serialize(writer, "N--NO BIAS/NOT APPLICABLE");
                    return;
            }
            throw new Exception("Cannot marshal type HateBias");
        }

        public static readonly HateBiasConverter Singleton = new HateBiasConverter();
    }

    internal class OpeningConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Opening) || t == typeof(Opening?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1 - DOOR":
                    return Opening.The1Door;
                case "2 - WINDOW":
                    return Opening.The2Window;
                case "3 - GARAGE":
                    return Opening.The3Garage;
                case "6 - UNKNOWN":
                    return Opening.The6Unknown;
            }
            throw new Exception("Cannot unmarshal type Opening");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Opening)untypedValue;
            switch (value)
            {
                case Opening.The1Door:
                    serializer.Serialize(writer, "1 - DOOR");
                    return;
                case Opening.The2Window:
                    serializer.Serialize(writer, "2 - WINDOW");
                    return;
                case Opening.The3Garage:
                    serializer.Serialize(writer, "3 - GARAGE");
                    return;
                case Opening.The6Unknown:
                    serializer.Serialize(writer, "6 - UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Opening");
        }

        public static readonly OpeningConverter Singleton = new OpeningConverter();
    }

    internal class SideConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Side) || t == typeof(Side?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1 - FRONT":
                    return Side.The1Front;
                case "2 - SIDE":
                    return Side.The2Side;
                case "3 - REAR":
                    return Side.The3Rear;
                case "4 - ROOF":
                    return Side.The4Roof;
                case "6 - UNKNOWN":
                    return Side.The6Unknown;
            }
            throw new Exception("Cannot unmarshal type Side");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Side)untypedValue;
            switch (value)
            {
                case Side.The1Front:
                    serializer.Serialize(writer, "1 - FRONT");
                    return;
                case Side.The2Side:
                    serializer.Serialize(writer, "2 - SIDE");
                    return;
                case Side.The3Rear:
                    serializer.Serialize(writer, "3 - REAR");
                    return;
                case Side.The4Roof:
                    serializer.Serialize(writer, "4 - ROOF");
                    return;
                case Side.The6Unknown:
                    serializer.Serialize(writer, "6 - UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Side");
        }

        public static readonly SideConverter Singleton = new SideConverter();
    }

    internal class AgeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Age) || t == typeof(Age?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "18-25":
                    return Age.The1825;
                case "26-30":
                    return Age.The2630;
                case "31-40":
                    return Age.The3140;
                case "41-50":
                    return Age.The4150;
                case "51-60":
                    return Age.The5160;
                case "61-70":
                    return Age.The6170;
                case "ADULT (18+)":
                    return Age.Adult18;
                case "JUVENILE (UNDER 18)":
                    return Age.JuvenileUnder18;
                case "OVER 70":
                    return Age.Over70;
                case "UNDER 18":
                    return Age.Under18;
                case "UNKNOWN":
                    return Age.Unknown;
            }
            throw new Exception("Cannot unmarshal type Age");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Age)untypedValue;
            switch (value)
            {
                case Age.The1825:
                    serializer.Serialize(writer, "18-25");
                    return;
                case Age.The2630:
                    serializer.Serialize(writer, "26-30");
                    return;
                case Age.The3140:
                    serializer.Serialize(writer, "31-40");
                    return;
                case Age.The4150:
                    serializer.Serialize(writer, "41-50");
                    return;
                case Age.The5160:
                    serializer.Serialize(writer, "51-60");
                    return;
                case Age.The6170:
                    serializer.Serialize(writer, "61-70");
                    return;
                case Age.Adult18:
                    serializer.Serialize(writer, "ADULT (18+)");
                    return;
                case Age.JuvenileUnder18:
                    serializer.Serialize(writer, "JUVENILE (UNDER 18)");
                    return;
                case Age.Over70:
                    serializer.Serialize(writer, "OVER 70");
                    return;
                case Age.Under18:
                    serializer.Serialize(writer, "UNDER 18");
                    return;
                case Age.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Age");
        }

        public static readonly AgeConverter Singleton = new AgeConverter();
    }

    internal class EthnicityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ethnicity) || t == typeof(Ethnicity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "HISPANIC ORIGIN":
                    return Ethnicity.HispanicOrigin;
                case "NOT OF HISPANIC ORIG":
                    return Ethnicity.NotOfHispanicOrig;
                case "UNKNOWN":
                    return Ethnicity.Unknown;
            }
            throw new Exception("Cannot unmarshal type Ethnicity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ethnicity)untypedValue;
            switch (value)
            {
                case Ethnicity.HispanicOrigin:
                    serializer.Serialize(writer, "HISPANIC ORIGIN");
                    return;
                case Ethnicity.NotOfHispanicOrig:
                    serializer.Serialize(writer, "NOT OF HISPANIC ORIG");
                    return;
                case Ethnicity.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Ethnicity");
        }

        public static readonly EthnicityConverter Singleton = new EthnicityConverter();
    }

    internal class SuspectGenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SuspectGender) || t == typeof(SuspectGender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FEMALE":
                    return SuspectGender.Female;
                case "MALE":
                    return SuspectGender.Male;
                case "UNKNOWN":
                    return SuspectGender.Unknown;
            }
            throw new Exception("Cannot unmarshal type SuspectGender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SuspectGender)untypedValue;
            switch (value)
            {
                case SuspectGender.Female:
                    serializer.Serialize(writer, "FEMALE");
                    return;
                case SuspectGender.Male:
                    serializer.Serialize(writer, "MALE");
                    return;
                case SuspectGender.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type SuspectGender");
        }

        public static readonly SuspectGenderConverter Singleton = new SuspectGenderConverter();
    }

    internal class RaceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Race) || t == typeof(Race?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AMERICAN INDIAN/ALAS":
                    return Race.AmericanIndianAlas;
                case "ASIAN/PACIFIC ISLAND":
                    return Race.AsianPacificIsland;
                case "BLACK":
                    return Race.Black;
                case "UNKNOWN":
                    return Race.Unknown;
                case "WHITE":
                    return Race.White;
            }
            throw new Exception("Cannot unmarshal type Race");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Race)untypedValue;
            switch (value)
            {
                case Race.AmericanIndianAlas:
                    serializer.Serialize(writer, "AMERICAN INDIAN/ALAS");
                    return;
                case Race.AsianPacificIsland:
                    serializer.Serialize(writer, "ASIAN/PACIFIC ISLAND");
                    return;
                case Race.Black:
                    serializer.Serialize(writer, "BLACK");
                    return;
                case Race.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
                case Race.White:
                    serializer.Serialize(writer, "WHITE");
                    return;
            }
            throw new Exception("Cannot marshal type Race");
        }

        public static readonly RaceConverter Singleton = new RaceConverter();
    }

    internal class TheftCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TheftCode) || t == typeof(TheftCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "23B-PURSE-SNATCHING":
                    return TheftCode.The23BPurseSnatching;
                case "23C-SHOPLIFTING":
                    return TheftCode.The23CShoplifting;
                case "23D-THEFT FROM BUILDING":
                    return TheftCode.The23DTheftFromBuilding;
                case "23F-THEFT FROM MOTOR VEHICLE":
                    return TheftCode.The23FTheftFromMotorVehicle;
                case "23G-THEFT OF MOTOR VEHICLE PARTS OR ACCESSORIES":
                    return TheftCode.The23GTheftOfMotorVehiclePartsOrAccessories;
                case "23H-ALL OTHER LARCENY":
                    return TheftCode.The23HAllOtherLarceny;
                case "24I-THEFT OF LICENSE PLATE":
                    return TheftCode.The24ITheftOfLicensePlate;
                case "24O-MOTOR VEHICLE THEFT":
                    return TheftCode.The24OMotorVehicleTheft;
            }
            throw new Exception("Cannot unmarshal type TheftCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TheftCode)untypedValue;
            switch (value)
            {
                case TheftCode.The23BPurseSnatching:
                    serializer.Serialize(writer, "23B-PURSE-SNATCHING");
                    return;
                case TheftCode.The23CShoplifting:
                    serializer.Serialize(writer, "23C-SHOPLIFTING");
                    return;
                case TheftCode.The23DTheftFromBuilding:
                    serializer.Serialize(writer, "23D-THEFT FROM BUILDING");
                    return;
                case TheftCode.The23FTheftFromMotorVehicle:
                    serializer.Serialize(writer, "23F-THEFT FROM MOTOR VEHICLE");
                    return;
                case TheftCode.The23GTheftOfMotorVehiclePartsOrAccessories:
                    serializer.Serialize(writer, "23G-THEFT OF MOTOR VEHICLE PARTS OR ACCESSORIES");
                    return;
                case TheftCode.The23HAllOtherLarceny:
                    serializer.Serialize(writer, "23H-ALL OTHER LARCENY");
                    return;
                case TheftCode.The24ITheftOfLicensePlate:
                    serializer.Serialize(writer, "24I-THEFT OF LICENSE PLATE");
                    return;
                case TheftCode.The24OMotorVehicleTheft:
                    serializer.Serialize(writer, "24O-MOTOR VEHICLE THEFT");
                    return;
            }
            throw new Exception("Cannot marshal type TheftCode");
        }

        public static readonly TheftCodeConverter Singleton = new TheftCodeConverter();
    }

    internal class UcrGroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UcrGroup) || t == typeof(UcrGroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AGGRAVATED ASSAULTS":
                    return UcrGroup.AggravatedAssaults;
                case "BURGLARY/BREAKING ENTERING":
                    return UcrGroup.BurglaryBreakingEntering;
                case "HOMICIDE":
                    return UcrGroup.Homicide;
                case "PART 2 MINOR":
                    return UcrGroup.Part2Minor;
                case "RAPE":
                    return UcrGroup.Rape;
                case "ROBBERY":
                    return UcrGroup.Robbery;
                case "THEFT":
                    return UcrGroup.Theft;
                case "UNAUTHORIZED USE":
                    return UcrGroup.UnauthorizedUse;
            }
            throw new Exception("Cannot unmarshal type UcrGroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UcrGroup)untypedValue;
            switch (value)
            {
                case UcrGroup.AggravatedAssaults:
                    serializer.Serialize(writer, "AGGRAVATED ASSAULTS");
                    return;
                case UcrGroup.BurglaryBreakingEntering:
                    serializer.Serialize(writer, "BURGLARY/BREAKING ENTERING");
                    return;
                case UcrGroup.Homicide:
                    serializer.Serialize(writer, "HOMICIDE");
                    return;
                case UcrGroup.Part2Minor:
                    serializer.Serialize(writer, "PART 2 MINOR");
                    return;
                case UcrGroup.Rape:
                    serializer.Serialize(writer, "RAPE");
                    return;
                case UcrGroup.Robbery:
                    serializer.Serialize(writer, "ROBBERY");
                    return;
                case UcrGroup.Theft:
                    serializer.Serialize(writer, "THEFT");
                    return;
                case UcrGroup.UnauthorizedUse:
                    serializer.Serialize(writer, "UNAUTHORIZED USE");
                    return;
            }
            throw new Exception("Cannot marshal type UcrGroup");
        }

        public static readonly UcrGroupConverter Singleton = new UcrGroupConverter();
    }

    internal class VictimGenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VictimGender) || t == typeof(VictimGender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FEMALE":
                    return VictimGender.Female;
                case "M - MALE":
                    return VictimGender.MMale;
                case "MALE":
                    return VictimGender.Male;
            }
            throw new Exception("Cannot unmarshal type VictimGender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VictimGender)untypedValue;
            switch (value)
            {
                case VictimGender.Female:
                    serializer.Serialize(writer, "FEMALE");
                    return;
                case VictimGender.MMale:
                    serializer.Serialize(writer, "M - MALE");
                    return;
                case VictimGender.Male:
                    serializer.Serialize(writer, "MALE");
                    return;
            }
            throw new Exception("Cannot marshal type VictimGender");
        }

        public static readonly VictimGenderConverter Singleton = new VictimGenderConverter();
    }

    internal class WeaponsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Weapons) || t == typeof(Weapons?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "11 - FIREARM (TYPE NOT STATED)":
                    return Weapons.The11FirearmTypeNotStated;
                case "12 - HANDGUN":
                    return Weapons.The12Handgun;
                case "12A - AUTOMATIC HANDGUN":
                    return Weapons.The12AAutomaticHandgun;
                case "13 - RIFLE":
                    return Weapons.The13Rifle;
                case "15 - OTHER FIREARM":
                    return Weapons.The15OtherFirearm;
                case "18 - BB AND PELLET GUNS":
                    return Weapons.The18BbAndPelletGuns;
                case "20 - KNIFE/CUTTING INSTRUMENT (ICEPICK, AX, ETC.)":
                    return Weapons.The20KnifeCuttingInstrumentIcepickAxEtc;
                case "30 - BLUNT OBJECT (CLUB, HAMMER, ETC.)":
                    return Weapons.The30BluntObjectClubHammerEtc;
                case "35 - MOTOR VEHICLE (WHEN USED AS WEAPON)":
                    return Weapons.The35MotorVehicleWhenUsedAsWeapon;
                case "40 - PERSONAL WEAPONS (HANDS, FEET, TEETH, ETC.)":
                    return Weapons.The40PersonalWeaponsHandsFeetTeethEtc;
                case "70 - DRUGS/NARCOTICS/SLEEPING PILLS":
                    return Weapons.The70DrugsNarcoticsSleepingPills;
                case "80 - OTHER WEAPON":
                    return Weapons.The80OtherWeapon;
                case "85 - ASPHYXIATION (BY DROWNING, STRANGULATION, SUFFOCATION)":
                    return Weapons.The85AsphyxiationByDrowningStrangulationSuffocation;
                case "99 - NONE":
                    return Weapons.The99None;
                case "U - UNKNOWN":
                    return Weapons.UUnknown;
            }
            throw new Exception("Cannot unmarshal type Weapons");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Weapons)untypedValue;
            switch (value)
            {
                case Weapons.The11FirearmTypeNotStated:
                    serializer.Serialize(writer, "11 - FIREARM (TYPE NOT STATED)");
                    return;
                case Weapons.The12Handgun:
                    serializer.Serialize(writer, "12 - HANDGUN");
                    return;
                case Weapons.The12AAutomaticHandgun:
                    serializer.Serialize(writer, "12A - AUTOMATIC HANDGUN");
                    return;
                case Weapons.The13Rifle:
                    serializer.Serialize(writer, "13 - RIFLE");
                    return;
                case Weapons.The15OtherFirearm:
                    serializer.Serialize(writer, "15 - OTHER FIREARM");
                    return;
                case Weapons.The18BbAndPelletGuns:
                    serializer.Serialize(writer, "18 - BB AND PELLET GUNS");
                    return;
                case Weapons.The20KnifeCuttingInstrumentIcepickAxEtc:
                    serializer.Serialize(writer, "20 - KNIFE/CUTTING INSTRUMENT (ICEPICK, AX, ETC.)");
                    return;
                case Weapons.The30BluntObjectClubHammerEtc:
                    serializer.Serialize(writer, "30 - BLUNT OBJECT (CLUB, HAMMER, ETC.)");
                    return;
                case Weapons.The35MotorVehicleWhenUsedAsWeapon:
                    serializer.Serialize(writer, "35 - MOTOR VEHICLE (WHEN USED AS WEAPON)");
                    return;
                case Weapons.The40PersonalWeaponsHandsFeetTeethEtc:
                    serializer.Serialize(writer, "40 - PERSONAL WEAPONS (HANDS, FEET, TEETH, ETC.)");
                    return;
                case Weapons.The70DrugsNarcoticsSleepingPills:
                    serializer.Serialize(writer, "70 - DRUGS/NARCOTICS/SLEEPING PILLS");
                    return;
                case Weapons.The80OtherWeapon:
                    serializer.Serialize(writer, "80 - OTHER WEAPON");
                    return;
                case Weapons.The85AsphyxiationByDrowningStrangulationSuffocation:
                    serializer.Serialize(writer, "85 - ASPHYXIATION (BY DROWNING, STRANGULATION, SUFFOCATION)");
                    return;
                case Weapons.The99None:
                    serializer.Serialize(writer, "99 - NONE");
                    return;
                case Weapons.UUnknown:
                    serializer.Serialize(writer, "U - UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Weapons");
        }

        public static readonly WeaponsConverter Singleton = new WeaponsConverter();
    }
}
