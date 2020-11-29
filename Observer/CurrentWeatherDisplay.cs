namespace Patterns.Observer
{
    internal class CurrentWeatherDisplay : IWeatherObserver
    {
        public double Humidity { get; set; }

        public void UpdateWeatherDate(WeatherData subject)
        {
            // todo  something with weather data
            Humidity = subject.GetHumidity + 1;
        }
    }
}