using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Korean;

/// <summary>
/// Base class for Korean number system converters.
/// </summary>
/// <param name="numeralCharacters">The character set to use for conversion.</param>
public abstract class KoreanNumeralConverterBase(IEastAsia10p4NumeralCharacters numeralCharacters) 
    : INumberSystemConverter
{
    private readonly IEastAsia10p4NumeralCharacters _numeralCharacters = numeralCharacters ?? throw new ArgumentNullException(nameof(numeralCharacters));

    /// <inheritdoc/>
    public string FromULong(ulong input)
        => (new KoreanFromConverter(_numeralCharacters)).Convert(input);

    /// <inheritdoc/>
    public ulong ToULong(string input)
        => (new KoreanToConverter(_numeralCharacters)).Convert(input);
}
