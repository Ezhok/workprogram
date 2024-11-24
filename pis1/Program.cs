using System;


namespace pis1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Wind;'Москва';2005.03.28;5.2;Северный|Precipitation;'Казань';2005.03.29;60;760|Meteo;'Санкт-Петербург';2005.03.27;24.6";
            MeteoDataProcessor.ProcessData(input);

            Console.WriteLine("Обработка строковых данных завершена.\n");
            

            MeteoDataProcessor.ProcessFile(@"E:\pis1_copy\data.txt");
            Console.WriteLine("Обработка файловых данных завершена.");
            

        }
    }
}
