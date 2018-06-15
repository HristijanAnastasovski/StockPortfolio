// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var batchQuoteDto = BatchQuoteDto.FromJson(jsonString);

namespace StockPortfolio.IEX_API.DTOs
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BatchQuoteDto
    {
        [JsonProperty("quote")]
        public Quote Quote { get; set; }
    }

    public partial class Quote
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("primaryExchange")]
        public PrimaryExchange PrimaryExchange { get; set; }

        [JsonProperty("sector")]
        public Sector Sector { get; set; }

        [JsonProperty("calculationPrice")]
        public CalculationPrice CalculationPrice { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("openTime")]
        public long OpenTime { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("closeTime")]
        public long CloseTime { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("latestPrice")]
        public double LatestPrice { get; set; }

        [JsonProperty("latestSource")]
        public LatestSource LatestSource { get; set; }

        [JsonProperty("latestTime")]
        public LatestTime LatestTime { get; set; }

        [JsonProperty("latestUpdate")]
        public long LatestUpdate { get; set; }

        [JsonProperty("latestVolume")]
        public long LatestVolume { get; set; }

        [JsonProperty("iexRealtimePrice")]
        public object IexRealtimePrice { get; set; }

        [JsonProperty("iexRealtimeSize")]
        public object IexRealtimeSize { get; set; }

        [JsonProperty("iexLastUpdated")]
        public object IexLastUpdated { get; set; }

        [JsonProperty("delayedPrice")]
        public double DelayedPrice { get; set; }

        [JsonProperty("delayedPriceTime")]
        public long DelayedPriceTime { get; set; }

        [JsonProperty("extendedPrice")]
        public double ExtendedPrice { get; set; }

        [JsonProperty("extendedChange")]
        public double ExtendedChange { get; set; }

        [JsonProperty("extendedChangePercent")]
        public double ExtendedChangePercent { get; set; }

        [JsonProperty("extendedPriceTime")]
        public long ExtendedPriceTime { get; set; }

        [JsonProperty("previousClose")]
        public double PreviousClose { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("changePercent")]
        public double ChangePercent { get; set; }

        [JsonProperty("iexMarketPercent")]
        public object IexMarketPercent { get; set; }

        [JsonProperty("iexVolume")]
        public object IexVolume { get; set; }

        [JsonProperty("avgTotalVolume")]
        public long AvgTotalVolume { get; set; }

        [JsonProperty("iexBidPrice")]
        public object IexBidPrice { get; set; }

        [JsonProperty("iexBidSize")]
        public object IexBidSize { get; set; }

        [JsonProperty("iexAskPrice")]
        public object IexAskPrice { get; set; }

        [JsonProperty("iexAskSize")]
        public object IexAskSize { get; set; }

        [JsonProperty("marketCap")]
        public long MarketCap { get; set; }

        [JsonProperty("peRatio")]
        public double PeRatio { get; set; }

        [JsonProperty("week52High")]
        public double Week52High { get; set; }

        [JsonProperty("week52Low")]
        public double Week52Low { get; set; }

        [JsonProperty("ytdChange")]
        public double YtdChange { get; set; }

        public double calculateDifference()
        {
            return LatestPrice - Open;
        }

        public double calculateDifferencePercentage()
        {
            double difference = calculateDifference();
            if (difference != 0)
                return difference > 0 ? (difference / Open) : (difference / Open) * -1;
            return 0;

        }

        private string _cname;
        public override string ToString()
        {
            _cname = $"{CompanyName} ({Symbol})";
            var symbol = calculateDifference() > 0 ? @"+" : "";
            StringBuilder sb = new StringBuilder();
            sb.Append(LatestPrice.ToString("$0.##").PadRight(10));
            sb.Append(" " + symbol + (calculateDifference().ToString("0.##") + calculateDifferencePercentage().ToString("(0.##%)")).PadLeft(9));
            return $"{_cname.PadRight(32)} {sb.ToString(),-22}";

        }
    }

    public enum CalculationPrice { Close };

    public enum LatestSource { Close };

    public enum LatestTime { June142018 };

    public enum PrimaryExchange { NasdaqGlobalSelect, NewYorkStockExchange };

    public enum Sector { CommunicationServices, ConsumerCyclical, Technology };

    public partial class BatchQuoteDto
    {
        public static Dictionary<string, BatchQuoteDto> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, BatchQuoteDto>>(json, DTOs.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Dictionary<string, BatchQuoteDto> self) => JsonConvert.SerializeObject(self, DTOs.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new CalculationPriceConverter(),
                new LatestSourceConverter(),
                new LatestTimeConverter(),
                new PrimaryExchangeConverter(),
                new SectorConverter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CalculationPriceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CalculationPrice) || t == typeof(CalculationPrice?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "close")
            {
                return CalculationPrice.Close;
            }
            throw new Exception("Cannot unmarshal type CalculationPrice");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CalculationPrice)untypedValue;
            if (value == CalculationPrice.Close)
            {
                serializer.Serialize(writer, "close"); return;
            }
            throw new Exception("Cannot marshal type CalculationPrice");
        }
    }

    internal class LatestSourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LatestSource) || t == typeof(LatestSource?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Close")
            {
                return LatestSource.Close;
            }
            throw new Exception("Cannot unmarshal type LatestSource");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LatestSource)untypedValue;
            if (value == LatestSource.Close)
            {
                serializer.Serialize(writer, "Close"); return;
            }
            throw new Exception("Cannot marshal type LatestSource");
        }
    }

    internal class LatestTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LatestTime) || t == typeof(LatestTime?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "June 14, 2018")
            {
                return LatestTime.June142018;
            }
            throw new Exception("Cannot unmarshal type LatestTime");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LatestTime)untypedValue;
            if (value == LatestTime.June142018)
            {
                serializer.Serialize(writer, "June 14, 2018"); return;
            }
            throw new Exception("Cannot marshal type LatestTime");
        }
    }

    internal class PrimaryExchangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PrimaryExchange) || t == typeof(PrimaryExchange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Nasdaq Global Select":
                    return PrimaryExchange.NasdaqGlobalSelect;
                case "New York Stock Exchange":
                    return PrimaryExchange.NewYorkStockExchange;
            }
            throw new Exception("Cannot unmarshal type PrimaryExchange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PrimaryExchange)untypedValue;
            switch (value)
            {
                case PrimaryExchange.NasdaqGlobalSelect:
                    serializer.Serialize(writer, "Nasdaq Global Select"); return;
                case PrimaryExchange.NewYorkStockExchange:
                    serializer.Serialize(writer, "New York Stock Exchange"); return;
            }
            throw new Exception("Cannot marshal type PrimaryExchange");
        }
    }

    internal class SectorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sector) || t == typeof(Sector?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Communication Services":
                    return Sector.CommunicationServices;
                case "Consumer Cyclical":
                    return Sector.ConsumerCyclical;
                case "Technology":
                    return Sector.Technology;
            }
            throw new Exception("Cannot unmarshal type Sector");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Sector)untypedValue;
            switch (value)
            {
                case Sector.CommunicationServices:
                    serializer.Serialize(writer, "Communication Services"); return;
                case Sector.ConsumerCyclical:
                    serializer.Serialize(writer, "Consumer Cyclical"); return;
                case Sector.Technology:
                    serializer.Serialize(writer, "Technology"); return;
            }
            throw new Exception("Cannot marshal type Sector");
        }
    }
}
