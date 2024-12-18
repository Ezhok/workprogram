using System;

namespace pis1
{
    public class Precipitation: MeteoData
    {
        public double Humidity { get; set; }
        public double Pressure { get; set; }

        public Precipitation(string place, string date, double humidity, double pressure) : base(place, date)
        {
            if (humidity < 0 || humidity > 100)
                throw new ArgumentException("Влажность должна быть в диапазоне от 0 до 100.", nameof(humidity));

            if (pressure < 0)
                throw new ArgumentException("Давление не может быть отрицательным.", nameof(pressure));

            Humidity = humidity;
            Pressure = pressure;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}, Дата измерений: {Date}, Влажность: {Humidity}%, Давление: {Pressure} мм рт. ст.");

        }
    }
}
