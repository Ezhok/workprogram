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
            string place = "������";
            string date = "2005.03.29";
            double humidity = 60;
            double pressure = 760;

            var pres = new Precipitation(place, date, humidity, pressure);

            // Act
            using var writer = new StringWriter();
            Console.SetOut(writer);
            pres.DisplayData();

            // Assert
            string expectedOutput = "����� ���������: ������, ���� ���������: 2005.03.29, ���������: 60%, ��������: 760 �� ��. ��.\n";
            string actualOutput = writer.ToString().Replace("\r\n", "\n");

            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void Precipitation_InvalidHumidity_ShouldThrowException()
        {
            // Arrange
            string place = "������";
            string date = "2005.03.29";
            double invalidHumidity = -5; // ������������ �������� ���������
            double pressure = 760;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Precipitation(place, date, invalidHumidity, pressure));
            Assert.Equal("��������� ������ ���� � ��������� �� 0 �� 100. (Parameter 'humidity')", exception.Message);
        }
        [Fact]
        public void Precipitation_InvalidPressure_ShouldThrowException()
        {
            // Arrange
            string place = "������";
            string date = "2005.03.29";
            double humidity = 60;
            double invalidPressure = -10; // ������������ �������� ��������

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Precipitation(place, date, humidity, invalidPressure));
            Assert.Equal("�������� �� ����� ���� �������������. (Parameter 'pressure')", exception.Message);
        }

        public class MeteoTesting
        {
            [Fact]
            public void Meteo_InvalidDate_ShouldThrowException()
            {

                var place = "������";
                var date = " ";
                var value = 25.5;


                var exception = Assert.Throws<ArgumentException>(() => new Meteo(place, date, value));


                Assert.Equal("���� �� ����� ���� null ��� ������. (Parameter 'date')", exception.Message);
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

                var place = "������";
                var date = "2005.03.28";
                var speed = 5.2;
                var direction = "��������";


                var wind = new Wind(place, date, speed, direction);

                using var writer = new StringWriter();
                Console.SetOut(writer);
                wind.DisplayData();

                string expectedOutput = "����� ���������: ������ ���� ���������: 2005.03.28 ���� �����: 5,2 �/� ����������� �����: �������� \n";
                string actualOutput = writer.ToString().Replace("\r\n", "\n");

                Assert.Equal(expectedOutput, actualOutput);

            }


            [Fact]
            public void Wind_InvalidSpeed_ShouldThrowException()
            {
                var place = "������";
                var date = "2005.03.28";
                var speed = -5.0;
                var direction = "��������";

                var exception = Assert.Throws<ArgumentException>(() => new Wind(place, date, speed, direction));
                Assert.Equal("�������� ����� �� ����� ���� �������������. (Parameter 'speed')", exception.Message);
            }
        }
    }
}
