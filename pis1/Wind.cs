using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal class Wind: MeteoData
    {
        public double Speed { get; set; }
        public string Direction { get; set; }

        public Wind(string place, string date, double speed, string direction) : base(place, date)
        {
            Speed = speed;
            Direction = direction;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Место измерения: {Place}");
            Console.WriteLine($"Дата измерений: {Date.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Сила ветра: {Speed} м/с");
            Console.WriteLine($"Направление ветра: {Direction}\n");
        }
    }
}
