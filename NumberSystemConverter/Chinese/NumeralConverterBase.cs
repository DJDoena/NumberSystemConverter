namespace DoenaSoft.NumberSystemConverter.Chinese;

public abstract class NumeralConverterBase : INumberSystemConverter
{
    private readonly INumeralCharacters _numeralCharacters;

    protected NumeralConverterBase(INumeralCharacters numeralCharacters)
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
        => (new FromUIntNumericalConverter(_numeralCharacters)).FromUInt(input);

    public ulong ToULong(string input)
        => (new ToUIntNumericalConverter(_numeralCharacters)).ToUInt(input);
}