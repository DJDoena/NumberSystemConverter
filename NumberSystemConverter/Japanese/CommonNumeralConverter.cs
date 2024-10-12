namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class CommonNumeralConverter
    : NumeralConverterBase
{
    public CommonNumeralConverter() : base(new CommonNumeralCharacters())
    {
    }
}