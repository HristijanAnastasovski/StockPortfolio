using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.IEX_API.DTOs
{
    class FinancialDataDto
    {
        [JsonProperty("beta")]
        public double Beta { get; set; }

        [JsonProperty("revenue")]
        public long Revenue { get; set; }

        [JsonProperty("marketcap")]
        public long Marketcap { get; set; }

        [JsonProperty("revenuePerEmployee")]
        public long RevenuePerEmployee { get; set; }
    }
}
