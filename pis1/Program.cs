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
            string input = "'Санкт-Пиетербург';2005.03.27;24.6\n'Москва';2005.03.28;5.2;Северный\n'Казань';2005.03.29;60;760";
            MeteoDataProcessor.ProcessData(input);

            Console.WriteLine("Обработка данных завершена.");
            Console.Read();

            //MeteoDataProcessor.ProcessFile("data.txt");

        }
    }
}
