namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class FinancialNumeralConverter
    : NumeralConverterBase
{
    public FinancialNumeralConverter() : base(new FinancialNumeralCharacters())
    {
    }
}