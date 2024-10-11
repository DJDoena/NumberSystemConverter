namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class OrdinaryTraditionalNumeralConverter : NumeralConverterBase
{
    public OrdinaryTraditionalNumeralConverter()
        : base(new OrdinaryTraditionalNumeralCharacters())
    {
    }
}