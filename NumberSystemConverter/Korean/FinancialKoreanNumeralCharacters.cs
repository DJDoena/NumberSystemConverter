namespace DoenaSoft.NumberSystemConverter.Korean;

public sealed class FinancialKoreanNumeralCharacters : NumeralCharacterBase
{
    public override char[] SingleDigits
        => ['零', '壹', '貳', '參', '肆', '伍', '陸', '柒', '捌', '玖'];

    public override char C10
        => '拾';

    public override char C100
        => '佰';

    public override char C1000
        => '仟';
}
