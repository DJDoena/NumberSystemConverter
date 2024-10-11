namespace DoenaSoft.NumberSystemConverter;

public static class GenericConverter
{
    public static string Convert(string input, INumberSystemConverter from, INumberSystemConverter to)
    {
        if (from == null)
        {
            throw new ArgumentNullException(nameof(from));
        }
        else if (to == null)
        {
            throw new ArgumentNullException(nameof(to));
        }

        var intValue = from.ToUInt(input);

        var result = to.FromUInt(intValue);

        return result;
    }

    public static string Convert(this INumberSystemConverter from, string input, INumberSystemConverter to)
        => Convert(input, from, to);

    public static uint GetUInt(string input, char[] validCharacters)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }
        else if (validCharacters == null || validCharacters.Length == 0)
        {
            throw new ArgumentNullException(nameof(validCharacters));
        }

        if (input.Any(c => !validCharacters.Contains(c)))
        {
            throw new InvalidInputException("Invalid character in input");
        }

        var result = 0U;

        var baseSystem = (uint)validCharacters.Length;

        for (var inputIndex = 0; inputIndex < input.Length; inputIndex++)
        {
            var current = (uint)Array.IndexOf(validCharacters, input[inputIndex]);

            result = (result * baseSystem) + current;
        }

        return result;
    }

    public static string GetString(uint input, char[] validCharacters)
    {
        if (validCharacters == null || validCharacters.Length == 0)
        {
            throw new ArgumentNullException(nameof(validCharacters));
        }

        if (input == 0U)
        {
            return validCharacters[0].ToString();
        }

        var number = input;

        var result = string.Empty;

        var baseSystem = (uint)validCharacters.Length;

        while (number > 0U)
        {
            var remainder = number % baseSystem;

            var current = validCharacters[remainder];

            result = $"{current}{result}";

            number /= baseSystem;
        }

        return result;
    }
}