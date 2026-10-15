namespace JEHF.StringManipulator
{
    public class StringManipulator
    {
        /// <summary>
        /// Invierte los caracteres de una cadena de texto.
        /// </summary>
        /// <param name="input">La cadena a invertir.</param>
        /// <returns>La cadena invertida. Si el parámetro es null, retorna null.</returns>
        public string? ReverseString(string? input)
        {
            if (input == null)
                return null;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Elimina todos los espacios (incluyendo múltiples y extremos) de una cadena.
        /// </summary>
        /// <param name="input">La cadena a limpiar.</param>
        /// <returns>La cadena sin espacios. Si el parámetro es null, retorna null.</returns>
        public string? RemoveSpaces(string? input)
        {
            if (input == null)
                return null;

            return input.Replace(" ", string.Empty);
        }
    }
}
