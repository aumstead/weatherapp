using CSI_WeatherApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSI_WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly HttpContext _context;

        public WeatherService(HttpClient httpClient, IServiceProvider services)
        {
            _httpClient = httpClient;
            _context = services.GetRequiredService<IHttpContextAccessor>().HttpContext;
        }

        public async Task<IEnumerable<Forecast>> GetSevenDayForecast(string latitude, string longitude)
        {
            var forecastUrl = await GetForecastUrl(latitude, longitude);

            var forecastContent = await GetForecastContent(forecastUrl);

            var forecastJson = JObject.Parse(forecastContent);

            var forecast = forecastJson["properties"]["periods"];

            var forecastList = new List<Forecast>();

            foreach (var f in forecast)
            {
                var forecastObj = new Forecast()
                {
                    Name = f["name"].ToString(),
                    Temperature = f["temperature"].ToString(),
                    DetailedForecast = f["detailedForecast"].ToString()
                };

                forecastList.Add(forecastObj);
            }

            return forecastList;
        }

        public async Task<string> GetForecastUrl(string latitude, string longitude)
        {
            var userAgent = _context.Request.Headers["User-Agent"].FirstOrDefault();
            if (userAgent == null) throw new Exception();

            _httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);

            var uri = new Uri($"https://api.weather.gov/points/{latitude},{longitude}");

            var res = _httpClient.GetAsync(uri).Result;
            if (res.IsSuccessStatusCode == false)
            {
                var errorContent = await res.Content.ReadAsStringAsync();
                var errorJson = JObject.Parse(errorContent);
                var errorText = errorJson["title"].ToString();
                throw new Exception(errorText);
            }

            var content = await res.Content.ReadAsStringAsync();

            var json = JObject.Parse(content);

            var forecastUrl = json["properties"]["forecast"].ToString();

            return forecastUrl;
        }

        public async Task<string> GetForecastContent(string forecastUrl)
        {
            var forecastRes = _httpClient.GetAsync(forecastUrl).Result;

            if (forecastRes.IsSuccessStatusCode == false)
            {
                throw new Exception(forecastRes.StatusCode.ToString());
            }

            var forecastContent = await forecastRes.Content.ReadAsStringAsync();

            return forecastContent;
        }
    }
}
