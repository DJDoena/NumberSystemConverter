namespace DoenaSoft.NumberSystemConverter.BaseX;

public abstract class BaseXConverterBase : INumberSystemConverter
{
    protected abstract char[] ValidCharacters { get; }

    public uint Base
        => (uint)this.ValidCharacters.Length;

    public virtual uint ToUInt(string input)
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

        var result = 0U;

        var baseSystem = (uint)this.ValidCharacters.Length;

        for (var inputIndex = 0; inputIndex < input.Length; inputIndex++)
        {
            var current = (uint)Array.IndexOf(this.ValidCharacters, input[inputIndex]);

            result = (result * baseSystem) + current;
        }

        return result;
    }

    public string FromUInt(uint input)
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

        var baseSystem = (uint)this.ValidCharacters.Length;

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