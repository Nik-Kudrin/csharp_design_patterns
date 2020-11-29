namespace Patterns.Observer
{
    internal class WeatherData
    {
        public delegate void NotificationHandler(WeatherData subject);

        private double humidity;


        public WeatherData()
        {
            humidity = 5;
        }


        public double GetHumidity
        {
            get { return humidity; }
        }

        public event NotificationHandler WeatherNotification;

        private void Notify()
        {
            if (WeatherNotification != null)
                WeatherNotification(this);
        }

        public void ChangeWeatherData()
        {
            // todo something operation with weather data
            humidity += 10;

            Notify();
        }
    }
}