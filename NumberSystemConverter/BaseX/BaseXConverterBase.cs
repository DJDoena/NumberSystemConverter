namespace DoenaSoft.NumberSystemConverter.BaseX;

/// <summary>
/// Base class for positional number system converters (binary, octal, decimal, hexadecimal, etc.).
/// </summary>
public abstract class BaseXConverterBase : INumberSystemConverter
{
    /// <summary>
    /// Gets the valid characters for this number system in order (e.g., '0'-'9' for decimal).
    /// </summary>
    protected abstract char[] ValidCharacters { get; }

    /// <summary>
    /// Gets the base (radix) of this number system.
    /// </summary>
    public ulong Base
        => (ulong)this.ValidCharacters.Length;

    /// <inheritdoc/>
    public virtual ulong ToULong(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentNullException(nameof(input));
        }
        else if (this.ValidCharacters == null || this.ValidCharacters.Length == 0)
        {
            throw new ArgumentNullException(nameof(this.ValidCharacters));
        }

        if (input.Any(c => !this.ValidCharacters.Contains(c)))
        {
            throw new InvalidInputException("Invalid character in input");
        }

        var result = 0UL;

        var baseSystem = (ulong)this.ValidCharacters.Length;

        for (var inputIndex = 0; inputIndex < input.Length; inputIndex++)
        {
            var current = (ulong)Array.IndexOf(this.ValidCharacters, input[inputIndex]);

            result = (result * baseSystem) + current;
        }

        return result;
    }

    /// <inheritdoc/>
    public string FromULong(ulong input)
    {
        if (this.ValidCharacters == null || this.ValidCharacters.Length == 0)
        {
            throw new ArgumentNullException(nameof(this.ValidCharacters));
        }

        if (input == 0U)
        {
            return this.ValidCharacters[0].ToString();
        }

        var number = input;

        var result = string.Empty;

        var baseSystem = (ulong)this.ValidCharacters.Length;

        while (number > 0U)
        {
            var remainder = number % baseSystem;

            var current = this.ValidCharacters[remainder];

            result = $"{current}{result}";

            number /= baseSystem;
        }

        return result;
    }
}