namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class FinancialNumeralCharacters : NumeralCharacterBase
{
    public override char[] SingleDigits
        => ['零', '壱', '弐', '参', '四', '五', '六', '七', '八', '九'];

    public override char C10
        => '拾';

    public override char C100
        => '百';

    public override char C1000
        => '千';
}