using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis1
{
    internal abstract class MeteoData
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }

        public MeteoData(string input)
        {
            input = input.Replace("'", "");
            string[] dates = input.Split(';');

            Place = dates[0];
            Date = DateTime.ParseExact(dates[1], "yyyy.MM.dd", CultureInfo.InvariantCulture);
        }

        public abstract void DisplayData();
    }
}
