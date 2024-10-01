using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal class Wind: IMetering
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public double Speed { get; set; }
        public string Direction { get; set; }

        public Wind(string input)
        {
            input = input.Replace("'", "");
            string[] dates = input.Split(';');

            Place = dates[0];
            Date = DateTime.ParseExact(dates[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
            Speed = double.Parse(dates[2], CultureInfo.InvariantCulture);
            Direction = dates[3];
        }

        public void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Сила ветра: {Speed} м/с");
            Console.WriteLine($"Направление ветра: {Direction}");
        }
    }
}
