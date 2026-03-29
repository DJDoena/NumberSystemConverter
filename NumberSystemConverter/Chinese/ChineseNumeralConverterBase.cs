using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Chinese;

/// <summary>
/// Base class for Chinese number system converters.
/// </summary>
public abstract class ChineseNumeralConverterBase : INumberSystemConverter
{
    private readonly IEastAsia10p4NumeralCharacters _numeralCharacters;

    /// <summary>
    /// Initializes a new instance of the converter with the specified character set.
    /// </summary>
    /// <param name="numeralCharacters">The character set to use for conversion.</param>
    protected ChineseNumeralConverterBase(IEastAsia10p4NumeralCharacters numeralCharacters)
    {
        _numeralCharacters = numeralCharacters ?? throw new ArgumentNullException(nameof(numeralCharacters));

        if (_numeralCharacters.SingleDigits == null)
        {
            throw new ArgumentNullException(nameof(numeralCharacters));
        }
        else if (_numeralCharacters.SingleDigits.Length != 10)
        {
            throw new ArgumentException("Numeral characters do not provide 10 single digit characters", nameof(numeralCharacters));
        }
    }

    /// <inheritdoc/>
    public string FromULong(ulong input)
        => (new ChineseFromConverter(_numeralCharacters)).Convert(input);

    /// <inheritdoc/>
    public ulong ToULong(string input)
        => (new ChineseToConverter(_numeralCharacters)).Convert(input);
}