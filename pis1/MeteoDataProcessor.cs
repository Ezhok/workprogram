using System.IO;
using System.Globalization;
using System;

namespace pis1
{
    public class MeteoDataProcessor
    {
        public static void ProcessData(string input)
        {
            string[] lines = input.Split('|');
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string type = parts[0];

                if (parts.Length < 4)
                    throw new ArgumentException($"Неверный формат данных: {line}");

                string place = parts[1].Replace("'", "");
                string date = parts[2];

                if (type == "Meteo")
                {
                    double value = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    var meteo = new Meteo(place, date, value);
                    meteo.DisplayData();
                }
                else if (type == "Wind")
                {
                    double speed = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    string direction = parts[4];
                    var wind = new Wind(place, date, speed, direction);
                    wind.DisplayData();
                }
                else if (type == "Precipitation")
                {
                    double humidity = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    double pressure = double.Parse(parts[4], CultureInfo.InvariantCulture);
                    var precipitation = new Precipitation(place, date, humidity, pressure);
                    precipitation.DisplayData();
                }
                else
                {
                    throw new ArgumentException($"Неверный тип данных: {type}");
                }
            }
        }

        public static void ProcessFile(string filePath)
        {
            string input = File.ReadAllText(filePath);
            ProcessData(input);
        }
    }
}
