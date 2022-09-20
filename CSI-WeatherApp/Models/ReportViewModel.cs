using System.Collections.Generic;

namespace CSI_WeatherApp.Models
{
    public class ReportViewModel
    {
        public List<Forecast> WeatherForecast { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
    }
}
