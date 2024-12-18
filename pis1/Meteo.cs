using System;

namespace pis1
{
    public class Meteo: MeteoData
    {
        public double Value { get; private set; }

        public Meteo(string place, string date, double value) : base(place, date)
        {
            if (string.IsNullOrWhiteSpace(date))
                throw new ArgumentException("Дата не может быть null или пустой.", nameof(date));

            Value = value;
        }

        public override void DisplayData()
        {
            Console.Write($"Место измерения: {Place} ");
            Console.Write($"Дата измерений: {Date} ");
            Console.Write($"Результаты измерений: {Value} ");
        }
    }
}
