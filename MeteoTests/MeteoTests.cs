using System;
using Xunit;
using pis1;

namespace MeteoTests
{
    public class MeteoTests
    {
        [Fact]
        public void Meteo_ValidInput_ShouldSetProperties()
        {
            // Arrange
            var place = "Москва";
            var date = "2024.11.25";
            var value = 25.5;

            // Act
            var meteo = new Meteo(place, date, value);

            // Assert
            Assert.Equal(place, meteo.Place);
            Assert.Equal(DateTime.ParseExact(date, "yyyy.MM.dd", null), meteo.Date);
            Assert.Equal(value, meteo.Value);
        }

        [Fact]
        public void Meteo_InvalidDate_ShouldThrowException()
        {
            // Arrange
            var place = "Москва";
            var date = "invalid_date";
            var value = 25.5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Meteo(place, date, value));
        }

        [Fact]
        public void Meteo_NullPlace_ShouldThrowException()
        {
            // Arrange
            var date = "2024.11.25";
            var value = 25.5;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Meteo(null, date, value));
        }        
    }

    public class WindTests
    {
        [Fact]
        public void Wind_ValidInput_ShouldSetProperties()
        {
            // Arrange
            var place = "Казань";
            var date = "2024.11.24";
            var speed = 10.5;
            var direction = "Северный";

            // Act
            var wind = new Wind(place, date, speed, direction);

            // Assert
            Assert.Equal(place, wind.Place);
            Assert.Equal(DateTime.ParseExact(date, "yyyy.MM.dd", null), wind.Date);
            Assert.Equal(speed, wind.Speed);
            Assert.Equal(direction, wind.Direction);
        }

        [Fact]
        public void Wind_InvalidSpeed_ShouldThrowException()
        {
            var place = "Москва";
            var date = "2024.11.25";
            var speed = -5.0; // Недопустимая скорость
            var direction = "Северный";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Wind(place, date, speed, direction));
            Assert.Equal("Скорость ветра не может быть отрицательной.", exception.Message); // Проверка сообщения об ошибке
        }              
    }

    public class MeteoDataProcessorTests
    {
        [Fact]
        public void ProcessData_ValidInput_ShouldNotThrow()
        {
            // Arrange
            var input = "Meteo;'Москва';2024.11.25;25.5";

            // Act & Assert
            var exception = Record.Exception(() => MeteoDataProcessor.ProcessData(input));
            Assert.Null(exception);
        }

        [Fact]
        public void ProcessData_InvalidInput_ShouldThrow()
        {
            // Arrange
            var input = "Invalid;'Москва';2024.11.25;25.5";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => MeteoDataProcessor.ProcessData(input));
        }

        
    }
}
