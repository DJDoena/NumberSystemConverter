namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class NumeralConverter : INumberSystemConverter
{
    public string FromULong(ulong input)
        => (new FromConverter(new NumeralCharacters())).Convert(input);

    public ulong ToULong(string input)
        => (new ToConverter(new NumeralCharacters())).Convert(input);
}