using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal class Meteo: IMetering
    {
        public string place { get; set; }
        public DateTime data {  get; set; }
        public double value { get; set; }

        public Meteo(string input)
        {
            input = input.Replace("'", "");
            string[] dates = input.Split(';');

            place = dates[0];
            data = DateTime.ParseExact(dates[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
            
            value = double.Parse(dates[2], CultureInfo.InvariantCulture);
        
        }

        public void DisplayData()
        {
            Console.WriteLine($"Место измерения: {place}");
            Console.WriteLine($"Дата измерений: {data.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Результаты измерений: {value}");
        }
    }
}
