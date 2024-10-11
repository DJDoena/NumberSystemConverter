namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class OrdinarySimplifiedNumeralConverter : NumeralConverterBase
{
    public OrdinarySimplifiedNumeralConverter()
        : base(new OrdinarySimplifiedNumeralCharacters())
    {
    }
}