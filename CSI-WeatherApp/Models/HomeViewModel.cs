using System.ComponentModel.DataAnnotations;

namespace CSI_WeatherApp.Models
{
    public class HomeViewModel
    {
        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public decimal Lat { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-90, 90, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public decimal Long { get; set; }
    }
}
