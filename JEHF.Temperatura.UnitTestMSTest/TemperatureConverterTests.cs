using Microsoft.VisualStudio.TestTools.UnitTesting;
using JEHF.Temperatura;

namespace JEHF.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter _converter = new TemperatureConverter();

        // ── CelsiusToFahrenheit ──────────────────────────────────────────────

        [TestMethod]
        public void CelsiusToFahrenheit_CeroGrados_Retorna32()
        {
            // Arrange
            double celsius = 0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_100Grados_Retorna212()
        {
            // Arrange
            double celsius = 100;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(212, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_Negativo40_Retorna_Negativo40()
        {
            // Arrange
            double celsius = -40;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(-40, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_37Grados_Retorna98punto6()
        {
            // Arrange
            double celsius = 37;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(98.6, resultado, 0.001);
        }

        // ── FahrenheitToCelsius ──────────────────────────────────────────────

        [TestMethod]
        public void FahrenheitToCelsius_32Grados_RetornaCero()
        {
            // Arrange
            double fahrenheit = 32;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(0, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_212Grados_Retorna100()
        {
            // Arrange
            double fahrenheit = 212;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(100, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_Negativo40_Retorna_Negativo40()
        {
            // Arrange
            double fahrenheit = -40;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(-40, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_98punto6_Retorna37()
        {
            // Arrange
            double fahrenheit = 98.6;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(37, resultado, 0.001);
        }
    }
}
