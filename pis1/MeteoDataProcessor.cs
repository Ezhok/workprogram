using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pis1
{
    internal class MeteoDataProcessor
    {
        public static void ProcessData(string input)
        {
            string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                Console.WriteLine("Обрабатывается строка: " + line);

                if (line.Contains(";"))
                {
                    string[] parts = line.Split(';');
                    Console.WriteLine("Разделение строки: ");
                    foreach (string part in parts)
                    {
                        Console.WriteLine(part);
                    }

                    if (parts.Length == 3)
                    {
                        Meteo meteo = new Meteo(line);
                        meteo.DisplayData();
                    }
                    else if (parts.Length == 4)
                    {
                        if (parts[3].Contains("Северный") || parts[3].Contains("Южный") || parts[3].Contains("Восточный") || parts[3].Contains("Западный"))
                        {
                            Wind wind = new Wind(line);
                            wind.DisplayData();
                        }
                        else
                        {
                            Precipitation precipitation = new Precipitation(line);
                            precipitation.DisplayData();
                        }
                    }
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

