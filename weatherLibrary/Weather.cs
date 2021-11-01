using System;

namespace weatherLibrary
{
    public class Weather
    {
        private double temperature;
        private double windSpeed;
        private double humidity;

        public Weather()
        {
            this.temperature = 0;
            this.humidity = 0;
            this.windSpeed = 0;
        }

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public double CalculateFeelsLikeTemperature()
        {
            return (-8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity - 0.14611605 * humidity * temperature - 0.012308094 * Math.Pow(temperature, 2) - 0.0164248277778 * Math.Pow(humidity, 2) + 0.002211732 * Math.Pow(temperature, 2) * humidity + 0.00072546 * temperature * Math.Pow(humidity, 2) - 0.000003582 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2));
        }

        public double CalculateWindChill()
        {
            if (temperature >= 10 || windSpeed <= 4.8)
            {
                return 0;
            }
            return 13.12 + (0.6215 * temperature) - (11.37 * Math.Pow(windSpeed, 0.16)) + (0.3965 * temperature * Math.Pow(windSpeed, 0.16));
        }
    }
}
