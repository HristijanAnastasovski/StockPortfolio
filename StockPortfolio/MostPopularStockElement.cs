using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio
{
    class MostPopularStockElement 
    {
        

        public string CompanyName { get; set; }

        public double OpenPrice { get; set; }

        public double LatestPrice { get; set; }


        public MostPopularStockElement(IEX_API.DTOs.QuoteDto quote)
        {
            CompanyName = $"{quote.CompanyName} ({quote.Symbol})";
            OpenPrice = quote.Open;
            LatestPrice = quote.LatestPrice;
        }
        //razlika od open do latest price
        public double calculateDifference()
        {
            return LatestPrice-OpenPrice;
        }

        public double calculateDifferencePercentage()
        {
            double difference = calculateDifference();
            if (difference != 0)
                return difference > 0 ? (difference / OpenPrice) : (difference / OpenPrice) * -1;
            return 0;

        }

        public override string ToString()
        {
            var symbol = calculateDifference() > 0 ? @"+" : "";
            StringBuilder sb = new StringBuilder();
            sb.Append(LatestPrice.ToString("$0.##").PadRight(10));
            sb.Append(" " + symbol + (calculateDifference().ToString("0.##") + calculateDifferencePercentage().ToString("(0.##%)")).PadLeft(9));
            return $"{CompanyName.PadRight(32)} {sb.ToString(), -22}";
            
        }


    }
}
