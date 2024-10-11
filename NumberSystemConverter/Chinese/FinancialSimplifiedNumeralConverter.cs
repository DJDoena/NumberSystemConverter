namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class FinancialSimplifiedNumeralConverter : NumeralConverterBase
{
    public FinancialSimplifiedNumeralConverter()
        : base(new FinancialSimplifiedNumeralCharacters())
    {
    }
}