namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class FinancialSimplifiedNumeralCharacters : INumeralCharacters
{
    public char[] SingleDigits
        => ['零', '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖'];

    public char C10
        => '拾';

    public char C100
        => '佰';

    public char C1_000
        => '仟';

    public char C10_000
        => '万';

    public char C100_000_000
        => '亿';
}