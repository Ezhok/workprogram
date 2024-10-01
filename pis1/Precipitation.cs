using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal class Precipitation: IMetering
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public double Humidity { get; set; }
        public int Pressure { get; set; }

        public Precipitation(string input)
        {
            input = input.Replace("'", "");
            string[] dates = input.Split(';');

            Place = dates[0];
            Date = DateTime.ParseExact(dates[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
            Humidity = double.Parse(dates[2], CultureInfo.InvariantCulture);
            Pressure = int.Parse(dates[3], CultureInfo.InvariantCulture);
        }

        public void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Влажность: {Humidity}%");
            Console.WriteLine($"Давление: {Pressure} мм рт. ст.");
        }
    }
}
