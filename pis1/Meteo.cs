using System;

namespace pis1
{
    public class Meteo: MeteoData
    {
        public double Value { get; set; }

        public Meteo(string place, string date, double value) : base(place, date)
        {
            Value = value;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Результаты измерений: {Value}");
        }
    }
}
