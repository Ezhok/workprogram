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
            Meteo meterReading = new Meteo("'Санкт-Пиетербург';2005.03.27;24.6");

            Console.WriteLine($"Место измерения: {meterReading.place}");
            Console.WriteLine($"Дата измерений:{meterReading.data.ToString("yyyy.MM.dd")}") ;
            Console.WriteLine($"Результаты измерений: {meterReading.value}");
            Console.WriteLine("T,encz rjirb");
        }
    }
}
