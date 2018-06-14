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
            
            CompanyName = quote.CompanyName;
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
                return difference / OpenPrice * 100;
            return 0;

        }

        public override string ToString()
        {
            
            return String.Format("{0} ${1} ${2} {3}%", CompanyName, LatestPrice.ToString("0.##"), calculateDifference().ToString("0.##"), calculateDifferencePercentage().ToString("0.##"));
            
        }


    }
}
