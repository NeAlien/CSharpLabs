using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laba6
{

    class Program
    {
        static Random rand = new Random();
        static string API_KEY = "86d70ec385a2764c6336fde933493e45";
        public struct Weather
        {
            public string Country { get; set; }
            public string Name { get; set; }
            public double Temp { get; set; }
            public string Description { get; set; }
        }

        public class API_call
        {
            public async Task<Weather> GetWeather(double latitude, double longitude)
            {

                var url = $"https://api.openweathermap.org/data/2.5/weather";
                var parameters = $"?lat={latitude}&lon={longitude}&appid={API_KEY}";

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);//ответ
                Weather result = new Weather();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Regex regex = new Regex("(?<=\"country\":\")[^\"]+(?=\")");
                    result.Country = regex.Match(jsonString).ToString();

                    regex = new Regex("(?<=\"name\":\")[^\"]+(?=\")");
                    result.Name = regex.Match(jsonString).ToString();
                    
                    regex = new Regex("(?<=\"temp\":)[^\"]+(?=,)");
                    result.Temp = Math.Round(Convert.ToDouble(regex.Match(jsonString).ToString().Replace(".", ",")) - 273);
                    
                    regex = new Regex("(?<=\"description\":\")[^\"]+(?=\")");
                    result.Description = regex.Match(jsonString).ToString();

                }

                return result;
            }
        }

        static void Main(string[] args)
        {
            API_call TestCallout = new API_call();

            Weather[] weatherList = new Weather[50];

            for (int i = 0; i < weatherList.Length; i++)
            {
                Weather temp = new Weather();

                do
                {
                    temp = TestCallout.GetWeather(rand.Next(-90, 90) + rand.NextDouble(), rand.Next(-180, 180) + rand.NextDouble()).GetAwaiter().GetResult();
                } while (temp.Country.Length == 0 && temp.Name.Length == 0);

                Console.WriteLine($"{temp.Country}, {temp.Name}: {temp.Temp} degrees, {temp.Description}");
                weatherList[i] = temp;
            }



            Weather outputData = (from data in weatherList
                                  select data).OrderBy(data => data.Temp).First();
            Console.WriteLine($"\nMin temperature:\n{outputData.Country}, {outputData.Name}: {outputData.Temp} degrees, {outputData.Description}");

            outputData = (from data in weatherList
                          select data).OrderBy(data => data.Temp).Last();
            Console.WriteLine($"\nMax temperature:\n{outputData.Country}, {outputData.Name}: {outputData.Temp} degrees, {outputData.Description}");


            double res = weatherList.Average(data => data.Temp);
            Console.WriteLine($"\nAverage world temperature: {res} degrees");

            int countryCount = weatherList.Select(data => data.Country).Distinct().Count();
            Console.WriteLine($"\nCountry count: {countryCount}");

            try
            {
                var firstSuitable = (from data in weatherList where data.Description == "rain" || data.Description == "clear sky" || data.Description == "few clouds" select data).First();
                Console.WriteLine($"\n{firstSuitable.Country}, {firstSuitable.Name}: {firstSuitable.Temp} degrees, {firstSuitable.Description}");
            }
            catch { Console.WriteLine("\nNo suitable data found"); }
        }
    }
}