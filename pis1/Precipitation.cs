using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal class Precipitation: MeteoData
    {
        public double Humidity { get; set; }
        public double Pressure { get; set; }

        public Precipitation(string place, string date, double humidity, double pressure) : base(place, date)
        {
            Humidity = humidity;
            Pressure = pressure;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Влажность: {Humidity}%");
            Console.WriteLine($"Давление: {Pressure} мм рт. ст.\n");
        }
    }
}
