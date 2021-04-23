using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.FAQEntries
{
    class Weather
    {
        public class WeatherArea
        {
            public string Latitude { get; set; }

            public string Longitude { get; set; }

            public CurrentWeather Currently { get; set; }
        }

        public class CurrentWeather
        {
            public string Summary { get; set; }

            public string Temperature { get; set; }
            public string Humidity { get; set; }
            public string Pressure { get; set; }
            public string Windspeed { get; set; }
            public string WindBearing { get; set; }
            public string Summary1 { get; set; }
            public string Icon { get; set; }
        }
    }
}
