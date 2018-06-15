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

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("latestPrice")]
        public double LatestPrice { get; set; }

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

    public partial class BatchQuoteDto
    {
        public static Dictionary<string, BatchQuoteDto> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, BatchQuoteDto>>(json);
    }
}
