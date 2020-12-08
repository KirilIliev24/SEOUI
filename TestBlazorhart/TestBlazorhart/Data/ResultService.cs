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
        public List<MeaningfulText> meaningfulTexts { get; set; }

        public string unZippedText = "";

        HttpClient client;

        public ResultService(IHttpClientFactory clientFactory)
        {
            results = new List<Result>();
            resultsFromCraler = new List<string>();
            linkPositions = new List<DateAndPosition>();
            meaningfulTexts = new List<MeaningfulText>();
            client = clientFactory.CreateClient();
        }

        public async Task GetResultAsync(string keyword, DateTime startDate, DateTime endDate)
        {

            try
            {
                int blazorIndex = 0;
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.TryAddWithoutValidation("startDate", startDate.ToString());
                client.DefaultRequestHeaders.TryAddWithoutValidation("endDate", endDate.ToString());
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


        public async Task GetLinksFromUrl(int index, int secondIndex, DateTime time)
        {
            try
            {
                var resultOne = results.Select(r => r).Where(r => r.blazorIndex == index).FirstOrDefault();
                if (secondIndex != -1)
                {
                    var resultTwo = results.Select(r => r).Where(r => r.blazorIndex == secondIndex).FirstOrDefault();
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.TryAddWithoutValidation("url", resultOne.Link);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("urlTwo", resultTwo.Link);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("date", time.ToString());
                    var responseOne = await client.GetStringAsync("https://localhost/SearchEngine/getLinksWithRegex");
                    resultsFromCraler.Clear();
                    resultsFromCraler = JsonConvert.DeserializeObject<List<string>>(responseOne);
                }
                else if (secondIndex == -1)
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.TryAddWithoutValidation("url", resultOne.Link);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("urlTwo", string.Empty);
                    client.DefaultRequestHeaders.TryAddWithoutValidation("date", time.ToString());
                    var responseTwo = await client.GetStringAsync("https://localhost/SearchEngine/getLinksWithRegex");
                    resultsFromCraler.Clear();
                    resultsFromCraler = JsonConvert.DeserializeObject<List<string>>(responseTwo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
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

        public async Task GetMeaningfulText(int index, DateTime time)
        {
            var result = results.Select(r => r).Where(r => r.blazorIndex == index).FirstOrDefault();

            try
            {
                unZippedText = "";
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.TryAddWithoutValidation("url", result.Link);
                client.DefaultRequestHeaders.TryAddWithoutValidation("date", time.ToString());
                var response = await client.GetStringAsync("https://localhost/SearchEngine/getMeaningfultext");

                meaningfulTexts = JsonConvert.DeserializeObject<List<MeaningfulText>>(response);
                var zippedText = meaningfulTexts.First();
                unZippedText = Zipper.Decompress(zippedText.Text);
            }
            catch (Exception e)
            {
                if (e is NullReferenceException || e is ArgumentNullException || e is HttpRequestException)
                    Console.WriteLine(e.Message);
            }
        }


        public string getLinkByIndex(int index)
        {
            var result = results.Select(r => r).Where(r => r.blazorIndex == index).FirstOrDefault();
            return result.Link;
        }
    }
}
