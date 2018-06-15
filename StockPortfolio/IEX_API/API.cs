using StockPortfolio.IEX_API.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime;
using System.Runtime.InteropServices;

namespace StockPortfolio.IEX_API
{
    // TODO: Refactor

    class API
    {
        // @symbol za koj ke se vratat podatoci
        // lista za sekoj den
        // mislam deka mapa bi odgovaralo najvekje
        // datum -> objekt so data so properties 'open, close, low, high, change, changePercentage'
        // ili neshto slicno
        public static async Task<IReadOnlyDictionary<DateTimeOffset, HistoricalDataDto>> GetHistoricalData(string symbol)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/chart/1m";
            API api = new API();

            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {
                    var historicalDataList = response.Content.ReadAsAsync<List<HistoricalDataDto>>().GetAwaiter().GetResult();
                    Dictionary<DateTimeOffset, HistoricalDataDto> historicalData = new Dictionary<DateTimeOffset, HistoricalDataDto>();
                    foreach (var d in historicalDataList)
                    {
                        if (d != null)
                        {
                            Debug.WriteLine("Date: " + d.Date);
                            Debug.WriteLine("Open: " + d.Open);
                            Debug.WriteLine("Close: " + d.Close);
                            Debug.WriteLine("Low: " + d.Low);
                            Debug.WriteLine("High: " + d.High);
                            Debug.WriteLine("Change: " + d.Change);
                            Debug.WriteLine("Change Percentage: " + d.ChangePercent);

                            // stavame se vo recnik kade shto KEY e datumot a VALUE e objekt od HistoricalDataDto so site informacii za toj datum
                            HistoricalDataDto data = new HistoricalDataDto(d.Open, d.High, d.Low, d.Close, d.Volume, d.UnadjustedVolume,
                                d.Change, d.ChangePercent, d.Vwap, d.Label, d.ChangeOverTime);
                            historicalData[d.Date] = data;


                        }
                    }
                    return historicalData;
                }

                return null;
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        // gi vrakja site aktivni simboli
        public static async Task<string[]> GetSymbols()
        {
            var API_PATH = $"https://api.iextrading.com/1.0/ref-data/symbols?filter=symbol,isEnabled,name";
            API api = new API();
            try
            {
                var response = await api.CallAPI(API_PATH);
                List<String> symbols = new List<string>();

                if (response.IsSuccessStatusCode)
                {
                    var symbolObjects = response.Content.ReadAsAsync<List<SymbolDto>>().GetAwaiter().GetResult();
                    foreach (var s in symbolObjects)
                        if (s != null && s.IsEnabled == true)
                            symbols.Add($"{s.Name} ({s.Symbol})");
                }



                return symbols.ToArray();
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        // @newsCount -> posledni N vesti za vrakjanje
        public static async Task<IEnumerable<NewsDto>> GetNews(string symbol, int newsCount)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/news/last/{newsCount}";
            API api = new API();
            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {
                    var news = response.Content.ReadAsAsync<List<NewsDto>>().GetAwaiter().GetResult();
                    foreach (var n in news)
                    {
                        Debug.WriteLine("DateTime: " + n.Datetime);
                        Debug.WriteLine("Headline: " + n.Headline);
                        Debug.WriteLine("Source: " + n.Source);
                        Debug.WriteLine("Url: " + n.Url);
                        Debug.WriteLine("Summary: " + n.Summary);
                        Debug.WriteLine("Related: " + n.Related);
                        Debug.WriteLine("Image: " + n.Image);
                    }

                    return news;
                }

                return Enumerable.Empty<NewsDto>();
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        // informacii za kompanijata so simbol @symbol
        // informacii od tip 'cena na akcii, kolku se trejda, skoro realtime'
        public static async Task<QuoteDto> GetQuote(string symbol)
        {

            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/quote";
            API api = new API();
            var response = await api.CallAPI(API_PATH);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync();
                    //string test = @"{'symbol':'MSFT','companyName':'Microsoft Corporation','primaryExchange':'Nasdaq Global Select','sector':'Technology','calculationPrice':'close','open': null,'openTime':1528810200772,'close':101.31,'closeTime':1528833600808,'high':101.449,'low':100.75,'latestPrice':101.31,'latestSource':'Close','latestTime':'June 12, 2018','latestUpdate':1528833600808,'latestVolume':18075465,'iexRealtimePrice':101.32,'iexRealtimeSize':200,'iexLastUpdated':1528833595083,'delayedPrice':101.31,'delayedPriceTime':1528833600808,'extendedPrice':101.31,'extendedChange':0,'extendedChangePercent':0,'extendedPriceTime':1528837185650,'previousClose':101.05,'change':0.26,'changePercent':0.00257,'iexMarketPercent':0.03012,'iexVolume':544433,'avgTotalVolume':24155353,'iexBidPrice':0,'iexBidSize':0,'iexAskPrice':0,'iexAskSize':0,'marketCap':778384739029,'peRatio':29.97,'week52High':102.69,'week52Low':68.02, 'ytdChange':0.1888952679651087}";
                    var quote = JsonConvert.DeserializeObject<QuoteDto>(json.Result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    if (quote != null)
                    {
                        Debug.WriteLine("Symbol: " + quote.Symbol);
                        Debug.WriteLine("Company Name: " + quote.CompanyName);
                        Debug.WriteLine("Primary Exchange: " + quote.PrimaryExchange);
                        Debug.WriteLine("Sector: " + quote.Sector);
                        Debug.WriteLine("Open: " + quote.Open);
                        return quote;
                    }
                }

                return null;
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        public static async Task<FinancialDataDto> GetFinancialData(string symbol)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/stats?filter=beta,revenue,marketcap,revenuePerEmployee";
            API api = new API();

            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<FinancialDataDto>().GetAwaiter().GetResult();
                    return data;
                }
                return null;
            }
            catch(System.Net.WebException ex)
            {
                throw ex;
            }
        }

        public static async Task<Dictionary<string, BatchQuoteDto>> GetBatchQuoteData(string[] symbolsArray)
        {
            var symbols = string.Join(",", symbolsArray.Select(item => item));
            var API_PATH = $"https://api.iextrading.com/1.0/stock/market/batch?symbols={symbols}&types=quote";
            API api = new API();

            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {

                    var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = BatchQuoteDto.FromJson(json);
                    return data;
                }
                return null;
            }
            catch (System.Net.WebException ex)
            {
                throw ex;
            }
        }

        public static async Task<QuoteDto> FilteredGetQuote(string symbol)
        {

            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/quote?filter=companyName,open,latestPrice,symbol";
            API api = new API();

            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync();
                    //string test = @"{'symbol':'MSFT','companyName':'Microsoft Corporation','primaryExchange':'Nasdaq Global Select','sector':'Technology','calculationPrice':'close','open': null,'openTime':1528810200772,'close':101.31,'closeTime':1528833600808,'high':101.449,'low':100.75,'latestPrice':101.31,'latestSource':'Close','latestTime':'June 12, 2018','latestUpdate':1528833600808,'latestVolume':18075465,'iexRealtimePrice':101.32,'iexRealtimeSize':200,'iexLastUpdated':1528833595083,'delayedPrice':101.31,'delayedPriceTime':1528833600808,'extendedPrice':101.31,'extendedChange':0,'extendedChangePercent':0,'extendedPriceTime':1528837185650,'previousClose':101.05,'change':0.26,'changePercent':0.00257,'iexMarketPercent':0.03012,'iexVolume':544433,'avgTotalVolume':24155353,'iexBidPrice':0,'iexBidSize':0,'iexAskPrice':0,'iexAskSize':0,'marketCap':778384739029,'peRatio':29.97,'week52High':102.69,'week52Low':68.02, 'ytdChange':0.1888952679651087}";
                    var quote = JsonConvert.DeserializeObject<QuoteDto>(json.Result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    if (quote != null)
                    {
                        return quote;
                    }
                }

                return null;
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        // @symbol -> za koja kompanija se baraat informacii
        // informacii od tipot, koj e CEO, od koja industrija e kompanijata, kratok opis na kompanijata
        public static async Task<CompanyInfoDto> GetCompanyInfo(string symbol)
        {
            var API_PATH = $"https://api.iextrading.com/1.0/stock/{symbol}/company";
            API api = new API();

            try
            {
                var response = await api.CallAPI(API_PATH);

                if (response.IsSuccessStatusCode)
                {
                    var info = response.Content.ReadAsAsync<CompanyInfoDto>().GetAwaiter().GetResult();
                    return info;
                }

                return null;
            }
            catch(System.Net.WebException e)
            {
                throw e;
            }
        }

        private async Task<HttpResponseMessage> CallAPI(string API_PATH)
        {
            if (API.hasInternet() == false)
                throw new System.Net.WebException("No internet connection detected, please try again later");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    client.BaseAddress = new Uri(API_PATH);
                    HttpResponseMessage response = await client.GetAsync(API_PATH);
                    return response;
                }
            }
            catch (System.Net.WebException e)
            {
                throw e;
            }        
        }


        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool hasInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
    }
}
