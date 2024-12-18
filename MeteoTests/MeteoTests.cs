using System;
using Xunit;
using pis1;

namespace MeteoTests
{
    public class PrecipitationTests
    {
        [Fact]
        public void PrecipitationTest()
        {
            //
            string place = "Казань";
            string date = "2005.03.29";
            double humidity = 60;
            double pressure = 760;

            var pres = new Precipitation(place, date, humidity, pressure);

            // Act
            using var writer = new StringWriter();
            Console.SetOut(writer);
            pres.DisplayData();

            // Assert
            string expectedOutput = "Место измерения: Казань, Дата измерений: 2005.03.29, Влажность: 60%, Давление: 760 мм рт. ст.\n";
            string actualOutput = writer.ToString().Replace("\r\n", "\n");

            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void Precipitation_InvalidHumidity_ShouldThrowException()
        {
            // Arrange
            string place = "Казань";
            string date = "2005.03.29";
            double invalidHumidity = -5; // Некорректное значение влажности
            double pressure = 760;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Precipitation(place, date, invalidHumidity, pressure));
            Assert.Equal("Влажность должна быть в диапазоне от 0 до 100. (Parameter 'humidity')", exception.Message);
        }
        [Fact]
        public void Precipitation_InvalidPressure_ShouldThrowException()
        {
            // Arrange
            string place = "Казань";
            string date = "2005.03.29";
            double humidity = 60;
            double invalidPressure = -10; // Некорректное значение давления

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Precipitation(place, date, humidity, invalidPressure));
            Assert.Equal("Давление не может быть отрицательным. (Parameter 'pressure')", exception.Message);
        }

        public class MeteoTesting
        {
            [Fact]
            public void Meteo_InvalidDate_ShouldThrowException()
            {

                var place = "Москва";
                var date = " ";
                var value = 25.5;


                var exception = Assert.Throws<ArgumentException>(() => new Meteo(place, date, value));


                Assert.Equal("Дата не может быть null или пустой. (Parameter 'date')", exception.Message);
            }

            [Fact]
            public void Meteo_NullPlace_ShouldThrowException()
            {

                var date = new DateTime(2024, 11, 24).ToString("yyyy.MM.dd");
                var value = 25.5;


                Assert.Throws<ArgumentNullException>(() => new Meteo(null, date, value));
            }
        }

        public class WindTests
        {

            [Fact]
            public void Wind_ValidInput_ShouldSetProperties()
            {

                var place = "Москва";
                var date = "2005.03.28";
                var speed = 5.2;
                var direction = "Северный";


                var wind = new Wind(place, date, speed, direction);

                using var writer = new StringWriter();
                Console.SetOut(writer);
                wind.DisplayData();

                string expectedOutput = "Место измерения: Москва Дата измерений: 2005.03.28 Сила ветра: 5,2 м/с Направление ветра: Северный \n";
                string actualOutput = writer.ToString().Replace("\r\n", "\n");

                Assert.Equal(expectedOutput, actualOutput);

            }


            [Fact]
            public void Wind_InvalidSpeed_ShouldThrowException()
            {
                var place = "Москва";
                var date = "2005.03.28";
                var speed = -5.0;
                var direction = "Северный";

                var exception = Assert.Throws<ArgumentException>(() => new Wind(place, date, speed, direction));
                Assert.Equal("Скорость ветра не может быть отрицательной. (Parameter 'speed')", exception.Message);
            }
        }
    }
}
