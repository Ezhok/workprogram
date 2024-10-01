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

        public Precipitation(string input) : base(input)
        {
            string[] dates = input.Split(';');
            Humidity = double.Parse(dates[2], CultureInfo.InvariantCulture);
            Pressure = double.Parse(dates[3], CultureInfo.InvariantCulture);
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Влажность: {Humidity}%");
            Console.WriteLine($"Давление: {Pressure} мм рт. ст.");
        }
    }
}
