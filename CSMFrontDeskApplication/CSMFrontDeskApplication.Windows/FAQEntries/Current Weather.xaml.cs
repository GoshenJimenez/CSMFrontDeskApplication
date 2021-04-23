using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static CSMFrontDeskApplication.Windows.FAQEntries.Weather;

namespace CSMFrontDeskApplication.Windows.FAQEntries
{
    /// <summary>
    /// Interaction logic for Current_Weather.xaml
    /// </summary>
    public partial class CurrentWeather : Window
    {

        private FAQEntries.List listWindow;

        public CurrentWeather(FAQEntries.List parentWindow = null)
        {
            InitializeComponent();
            listWindow = parentWindow;
        }

        private void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://api.darksky.net/forecast/64ee9d4e589bb2cb3788596fd477b0f7/14.8781,120.4546");

            var request = new RestRequest("", Method.GET);

            IRestResponse response = client.Execute(request);

            var content = response.Content;

            var area = JsonConvert.DeserializeObject<WeatherArea>(content);

            lblSummary.Content = DateTime.Now.ToString("hh:mm tt");
            lblSummary.Content = area.Currently.Summary;
            lblTemperature.Content = "Temperature :" + area.Currently.Temperature;
            lblHumidity.Content = "Humidity :" + area.Currently.Humidity;
            lblPressure.Content = "Pressure :" + area.Currently.Pressure;
            lblWindspeed.Content = "Windspeed :" + area.Currently.Windspeed;
            lblWindBearing.Content = "WindBearing :" + area.Currently.WindBearing;
            lblSummary1.Content = "Summary :" + area.Currently.Summary;
        }
    }
}

