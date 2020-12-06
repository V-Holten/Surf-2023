using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surf_2022.Models.WeatherData
{
    public class ResultViewModel
    {
        public string ResultCity { get; set; }
        public string ResultCountry { get; set; }
        public string ResultLat { get; set; }
        public string ResultLon { get; set; }
        public string ResultDescription { get; set; }
        public string ResultHumidity { get; set; }
        public string ResultTempFeelsLike { get; set; }
        public string ResultTemp { get; set; }
        public string ResultTempMax { get; set; }
        public string ResultTempMin { get; set; }
        public string ResultWeatherIcon { get; set; }
    }
}
