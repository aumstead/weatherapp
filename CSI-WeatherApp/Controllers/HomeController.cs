using CSI_WeatherApp.Models;
using CSI_WeatherApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWeatherService _weatherService;

        public HomeController(ILogger<HomeController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("latitude", model.Lat.ToString());
                queryParams.Add("longitude", model.Long.ToString());
                return RedirectToAction("Report", queryParams);
            } 
            return View();
        }

        public async Task<IActionResult> Report(string latitude, string longitude)
        {
            var viewModel = new ReportViewModel();

            try
            {
                var weatherForecast = await _weatherService.GetSevenDayForecast(latitude, longitude);
                viewModel.WeatherForecast = weatherForecast.ToList();
                viewModel.Lat = latitude;
                viewModel.Long = longitude;
            }
            catch (Exception ex)
            {
                var errorViewModel = new ErrorViewModel()
                {
                    Message = ex.Message,
                };
                return View("Error", errorViewModel);
            }            

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
