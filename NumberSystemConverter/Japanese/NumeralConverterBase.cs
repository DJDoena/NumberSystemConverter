using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Japanese;

public abstract class NumeralConverterBase(I10p4NumeralCharacters numeralCharacters) 
    : INumberSystemConverter
{
    private readonly I10p4NumeralCharacters _numeralCharacters = numeralCharacters;

    public string FromULong(ulong input)
        => (new FromConverter(_numeralCharacters)).Convert(input);

    public ulong ToULong(string input)
        => (new ToConverter(_numeralCharacters)).Convert(input);
}