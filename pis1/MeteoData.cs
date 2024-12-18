using System;
using System.Globalization;

namespace pis1
{
    public abstract class MeteoData
    {
        public string Place { get; private set; }
        public string Date { get; private set; }

        public MeteoData(string place, string date)
        {
            if (string.IsNullOrWhiteSpace(place))
                throw new ArgumentNullException(nameof(place), "Место измерения не может быть пустым.");

            if (string.IsNullOrWhiteSpace(date))
                throw new ArgumentException("Дата не может быть null или пустой.", nameof(date));

            Place = place;
            Date = date;
        }

        public virtual void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date}");
        }
    }
}
