using CSI_WeatherApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSI_WeatherApp.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<Forecast>> GetSevenDayForecast(string latitude, string longitude);
        Task<string> GetForecastUrl(string latitude, string longitude);
        Task<string> GetForecastContent(string forecastUrl);
    }
}
