using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meteo meterReading = new Meteo("'Санкт-Петербург';2005.03.27;24.6");
            meterReading.DisplayData();

            Wind windReading = new Wind("'Санкт-Петербург';2005.03.27;5.2;Северный");
            windReading.DisplayData();

            Precipitation precipitationReading = new Precipitation("'Санкт-Петербург';2005.03.27;60;760");
            precipitationReading.DisplayData();

        }
    }
}
