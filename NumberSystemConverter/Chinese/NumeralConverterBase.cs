namespace DoenaSoft.NumberSystemConverter.Chinese;

public abstract class NumeralConverterBase : INumberSystemConverter
{
    private readonly INumeralCharacters _numeralCharacters;

    protected NumeralConverterBase(INumeralCharacters numeralCharacters)
    {
        _numeralCharacters = numeralCharacters ?? throw new ArgumentNullException(nameof(numeralCharacters));

        if (_numeralCharacters.SingleDigits == null
            || _numeralCharacters.SingleDigits.Length != 10)
        {
            throw new ArgumentException("Numeral characters do not provide 10 single digit characters", nameof(numeralCharacters));
        }
    }

    public string FromUInt(uint input)
        => (new FromUIntNumericalConverter(_numeralCharacters)).FromUInt(input);

    public uint ToUInt(string input)
        => (new ToUIntNumericalConverter(_numeralCharacters)).ToUInt(input);
}