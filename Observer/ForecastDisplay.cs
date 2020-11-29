namespace Patterns.Observer
{
    internal class ForecastDisplay : IWeatherObserver
    {
        public double Humidity { get; set; }

        public void UpdateWeatherDate(WeatherData subject)
        {
            // todo something with weather date

            Humidity = subject.GetHumidity + 25;
        }
    }
}