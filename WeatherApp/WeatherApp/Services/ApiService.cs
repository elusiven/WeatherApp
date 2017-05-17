using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class ApiService : IApiService
    {
        private const string DarkSkyKey = "a23f8d7f3f4a84900aba580cdb8b263d";
        private const string DarkSkyUrl = "https://api.darksky.net/forecast/";

        private readonly HttpClient _client = new HttpClient();

        public async Task<Weather> GetAsync(double lat, double lon, Dictionary<string, string> headers = null)
        {
            _client.BaseAddress = new Uri(DarkSkyUrl);
            _client.DefaultRequestHeaders.Clear();

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    _client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            var response = await _client.GetAsync($"{DarkSkyKey}/{lat},{lon}");
            var result = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Weather>(result);
            return json;
        }
    }
}
