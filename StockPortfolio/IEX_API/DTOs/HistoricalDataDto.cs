using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.IEX_API.DTOs
{
    class HistoricalDataDto
    {
        public HistoricalDataDto(double open, double high, double low, double close, long volume, long unadjustedVolume,
            double change, double changePercent, double vwap, string label, double changeOverTime)
        {
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
            UnadjustedVolume = unadjustedVolume;
            Change = change;
            ChangePercent = changePercent;
            Vwap = vwap;
            Label = label;
            ChangeOverTime = changeOverTime;
        }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("unadjustedVolume")]
        public long UnadjustedVolume { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("changePercent")]
        public double ChangePercent { get; set; }

        [JsonProperty("vwap")]
        public double Vwap { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("changeOverTime")]
        public double ChangeOverTime { get; set; }
    }
}
