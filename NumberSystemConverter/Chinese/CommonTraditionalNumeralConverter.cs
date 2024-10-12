namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class CommonTraditionalNumeralConverter : NumeralConverterBase
{
    public CommonTraditionalNumeralConverter()
        : base(new CommonTraditionalNumeralCharacters())
    {
    }
}