using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace pis1
{
    internal class MeteoDataProcessor
    {
        public static void ProcessData(string input)
        {
            string[] lines = input.Split('|');

            

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string type = parts[0];
                string place = parts[1].Replace("'", "");
                string date = parts[2];
                

                if (type == "Meteo")
                {
                    double value = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    Meteo meteo = new Meteo(place, date, value);
                    meteo.DisplayData();
                }
                else if (type == "Wind")
                {
                    double speed = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    string direction = parts[4];
                    Wind wind = new Wind(place, date, speed, direction);
                    wind.DisplayData();
                }
                else if (type == "Precipitation")
                {
                    double humidity = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    double pressure = double.Parse(parts[4], CultureInfo.InvariantCulture);
                    Precipitation precipitation = new Precipitation(place, date, humidity, pressure);
                    precipitation.DisplayData();
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

