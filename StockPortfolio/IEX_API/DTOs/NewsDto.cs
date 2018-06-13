using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.IEX_API.DTOs
{
    class NewsDto
    {
        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
