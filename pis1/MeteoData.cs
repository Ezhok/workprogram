using System;
using System.Collections.Generic;
using System.Data;
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

        public MeteoData(string place, string date)
        {
            Place = place;
            Date = DateTime.ParseExact(date, "yyyy.MM.dd", CultureInfo.InvariantCulture);
        }

        

        public abstract void DisplayData();
    }
}
