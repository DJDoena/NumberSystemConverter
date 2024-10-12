namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class CommonSimplifiedNumeralConverter : NumeralConverterBase
{
    public CommonSimplifiedNumeralConverter()
        : base(new CommonSimplifiedNumeralCharacters())
    {
    }
}