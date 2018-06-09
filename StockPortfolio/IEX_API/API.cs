using StockPortfolio.IEX_API.POCOS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.IEX_API
{
    // TODO: Refactor
    class API
    {
        // lista za sekoj den
        // mislam deka mapa bi odgovaralo najvekje
        // datum -> objekt so data so properties 'open, close, low, high, change, changePercentage'
        // ili neshto slicno
        public static void GetHistoricalData(string symbol)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/chart/1m";
            API api = new API();
            var response = api.CallAPI(API_PATH);

            if (response.IsSuccessStatusCode)
            {
                var historicalDataList = response.Content.ReadAsAsync<List<HistoricalDataPOCO>>().GetAwaiter().GetResult();

                foreach (var historicalData in historicalDataList)
                {
                    if (historicalData != null)
                    {
                        Debug.WriteLine("Date: " + historicalData.date);
                        Debug.WriteLine("Open: " + historicalData.open);
                        Debug.WriteLine("Close: " + historicalData.close);
                        Debug.WriteLine("Low: " + historicalData.low);
                        Debug.WriteLine("High: " + historicalData.high);
                        Debug.WriteLine("Change: " + historicalData.change);
                        Debug.WriteLine("Change Percentage: " + historicalData.changePercent);
                    }
                }
            }
            
        }

        // informacii za kompanijata so simbol @symbol
        // moze samo direktno da go vrakja objektot 'quote'
        public static void GetQuote(string symbol)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/quote";
            API api = new API();
            var response = api.CallAPI(API_PATH);

            if (response.IsSuccessStatusCode)
            {
                var quote = response.Content.ReadAsAsync<QuotePOCO>().GetAwaiter().GetResult();
                if (quote != null)
                {
                    Debug.WriteLine("Symbol: " + quote.symbol);
                    Debug.WriteLine("Company Name: " + quote.companyName);
                    Debug.WriteLine("Primary Exchange: " + quote.primaryExchange);
                    Debug.WriteLine("Sector: " + quote.sector);
                }
            }
        }

        private HttpResponseMessage CallAPI(string API_PATH)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.BaseAddress = new Uri(API_PATH);
                HttpResponseMessage response = client.GetAsync(API_PATH).GetAwaiter().GetResult();

                return response;
            }
        }
    }
}
