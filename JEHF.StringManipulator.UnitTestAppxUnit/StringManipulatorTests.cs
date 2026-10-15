using Xunit;
using JEHF.StringManipulator;

namespace JEHF.StringManipulator.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator _manipulator = new StringManipulator();

        // ── ReverseString ────────────────────────────────────────────────────

        [Fact]
        public void ReverseString_CadenaSimple_RetornaCadenaInvertida()
        {
            // Arrange
            string input = "hola";

            // Act
            string? resultado = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal("aloh", resultado);
        }

        [Fact]
        public void ReverseString_CadenaPalindromo_RetornaMismaCadena()
        {
            // Arrange
            string input = "ana";

            // Act
            string? resultado = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal("ana", resultado);
        }

        [Fact]
        public void ReverseString_CadenaVacia_RetornaCadenaVacia()
        {
            // Arrange
            string input = "";

            // Act
            string? resultado = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal("", resultado);
        }

        [Fact]
        public void ReverseString_CadenaNula_RetornaNull()
        {
            // Arrange
            string? input = null;

            // Act
            string? resultado = _manipulator.ReverseString(input);

            // Assert
            Assert.Null(resultado);
        }

        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("12345", "54321")]
        [InlineData("A", "A")]
        public void ReverseString_MultiplesCadenas_RetornaInvertidas(string input, string expected)
        {
            // Act
            string? resultado = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, resultado);
        }

        // ── RemoveSpaces ─────────────────────────────────────────────────────

        [Fact]
        public void RemoveSpaces_CadenaConEspacios_RetornaSinEspacios()
        {
            // Arrange
            string input = "hola mundo";

            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("holamundo", resultado);
        }

        [Fact]
        public void RemoveSpaces_CadenaConMultiplesEspacios_RetornaSinEspacios()
        {
            // Arrange
            string input = "  hola   mundo  ";

            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("holamundo", resultado);
        }

        [Fact]
        public void RemoveSpaces_CadenaSinEspacios_RetornaMismaCadena()
        {
            // Arrange
            string input = "holamundo";

            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("holamundo", resultado);
        }

        [Fact]
        public void RemoveSpaces_CadenaVacia_RetornaCadenaVacia()
        {
            // Arrange
            string input = "";

            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("", resultado);
        }

        [Fact]
        public void RemoveSpaces_CadenaNula_RetornaNull()
        {
            // Arrange
            string? input = null;

            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Null(resultado);
        }

        [Theory]
        [InlineData("a b c", "abc")]
        [InlineData(" dotnet ", "dotnet")]
        [InlineData("pruebas unitarias", "pruebasunitarias")]
        public void RemoveSpaces_MultiplesCadenas_RetornaSinEspacios(string input, string expected)
        {
            // Act
            string? resultado = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, resultado);
        }
    }
}
