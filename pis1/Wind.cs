using System;

namespace pis1
{
    public class Wind : MeteoData
    {
        public double Speed { get; private set; }
        public string Direction { get; private set; }

        public Wind(string place, string date, double speed, string direction) : base(place, date)
        {
            if (speed < 0)
                throw new ArgumentException("Скорость ветра не может быть отрицательной.", nameof(speed));

            if (string.IsNullOrEmpty(direction))
                throw new ArgumentNullException(nameof(direction), "Направление ветра не может быть null или пустым.");

            Speed = speed;
            Direction = direction;
        }

        public override void DisplayData()
        {
            Console.Write($"Место измерения: {Place} ");
            Console.Write($"Дата измерений: {Date} ");
            Console.Write($"Сила ветра: {Speed} м/с ");
            Console.WriteLine($"Направление ветра: {Direction} ");
        }
    }
}
