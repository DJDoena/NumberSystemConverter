namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class FinancialSimplifiedNumeralCharacters : NumeralCharactersBase
{
    public override char[] SingleDigits
        => ['零', '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖'];

    public override char C10
        => '拾';

    public override char C100
        => '佰';

    public override char C1000
        => '仟';

    public override char C1_0000
        => '万';

    public override char C1_0000_0000
        => '亿';
}