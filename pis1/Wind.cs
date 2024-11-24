using System;

namespace pis1
{
    public class Wind : MeteoData
    {
        public double Speed { get; set; }
        public string Direction { get; set; }

        public Wind(string place, string date, double speed, string direction) : base(place, date)
        {
            // Валидация скорости
            if (speed < 0)
            {
                throw new ArgumentException("Скорость ветра не может быть отрицательной.");
            }

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
