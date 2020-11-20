using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace TestBlazorhart.Data
{
    public class ResultService
    {

        public List<Result> results { get; set; }
        public List<string> resultsFromCraler { get; set; }
        public List<string> keywords { get; set; }
        public List<DateAndPosition> linkPositions { get; set; }

        HttpClient client;

        public ResultService(IHttpClientFactory clientFactory)
        {
            results = new List<Result>();
            resultsFromCraler = new List<string>();
            linkPositions = new List<DateAndPosition>();

            client = clientFactory.CreateClient();
        }

        public async Task GetResultAsync(string keyword)
        {

            try
            {

                int blazorIndex = 0;
                var response = await client.GetStringAsync($"https://localhost/SearchEngine/getByKeyword/{keyword}");
                var receivedData = JsonConvert.DeserializeObject<Result[]>(response);
                results = receivedData.ToList();
                foreach (var r in results)
                {
                    r.blazorIndex = blazorIndex;
                    blazorIndex++;
                }
            }
            catch (Exception e)
            {
                if (e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.Message);
            }


        }

        public async Task GetAllKeyords()
        {
            try
            {
                var response = await client.GetStringAsync($"https://localhost/SearchEngine/getKeywords");
                var receivedData = JsonConvert.DeserializeObject<string[]>(response);
                keywords = receivedData.ToList();
            }
            catch (Exception e)
            {
                if (e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.StackTrace);
            }
        }

        public async Task AddKeyord(string keyword)
        {

            try
            {
                await client.PostAsync($"https://localhost/SearchEngine/search/addKeyword/{keyword}", null);
            }
            catch (Exception e)
            {
                if (e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.Message);
            }
        }


        public async Task GetLinksFromUrl(int index, DateTime time)
        {
            var result = results.Select(r => r).Where(r => r.blazorIndex == index).FirstOrDefault();

            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("url", result.Link);
                client.DefaultRequestHeaders.Add("date", time.ToString());
                var response = await client.GetStringAsync("https://localhost/SearchEngine/getLinksWithRegex");
                resultsFromCraler.Clear();
                resultsFromCraler = JsonConvert.DeserializeObject<List<string>>(response);
            }
            catch (Exception e)
            {
                if (e is NullReferenceException || e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.Message);
            }
        }

        public async Task GetLinkPositions(int index, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                linkPositions.Clear();
                var result = results.Select(r => r).Where(r => r.blazorIndex == index).FirstOrDefault();

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("link", result.Link);
                client.DefaultRequestHeaders.Add("keywords", result.keyword);
                if (startDate != null && endDate != null)
                {
                    client.DefaultRequestHeaders.Add("startDate", startDate.ToString());
                    client.DefaultRequestHeaders.Add("endDate", endDate.ToString());
                }
                var response = await client.GetStringAsync($"https://localhost/SearchEngine/positions/byDatePeriod");
                var receivedData = JsonConvert.DeserializeObject<List<DateAndPosition>>(response);

                linkPositions = receivedData;

            }
            catch (Exception e)
            {
                if (e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.Message);
            }
        }
    }
}
