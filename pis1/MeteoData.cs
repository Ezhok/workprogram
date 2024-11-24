using System;
using System.Globalization;

namespace pis1
{
    public abstract class MeteoData
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }

        public MeteoData(string place, string date)
        {
            Place = place ?? throw new ArgumentNullException(nameof(place));

            try
            {
                Date = DateTime.ParseExact(date, "yyyy.MM.dd", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                throw new ArgumentException($"Некорректный формат даты: {date}. Ожидается формат yyyy.MM.dd.", nameof(date));
            }
        }

        

        public abstract void DisplayData();
    }
}
