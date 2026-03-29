using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Japanese;

/// <summary>
/// Base class for Japanese number system converters.
/// </summary>
/// <param name="numeralCharacters">The character set to use for conversion.</param>
public abstract class JapaneseNumeralConverterBase(IEastAsia10p4NumeralCharacters numeralCharacters)
    : INumberSystemConverter
{
    private readonly IEastAsia10p4NumeralCharacters _numeralCharacters = numeralCharacters;

    /// <inheritdoc/>
    public string FromULong(ulong input)
        => (new JapaneseFromConverter(_numeralCharacters)).Convert(input);

    /// <inheritdoc/>
    public ulong ToULong(string input)
        => (new JapaneseToConverter(_numeralCharacters)).Convert(input);
}