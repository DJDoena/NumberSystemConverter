using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Chinese;

public abstract class NumeralConverterBase : INumberSystemConverter
{
    private readonly I10p4NumeralCharacters _numeralCharacters;

    protected NumeralConverterBase(I10p4NumeralCharacters numeralCharacters)
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

    public string FromULong(ulong input)
        => (new FromConverter(_numeralCharacters)).Convert(input);

    public ulong ToULong(string input)
        => (new ToConverter(_numeralCharacters)).Convert(input);
}