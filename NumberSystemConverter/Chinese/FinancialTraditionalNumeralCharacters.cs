namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class FinancialTraditionalNumeralCharacters : INumeralCharacters
{
    public char[] SingleDigits
        => ['零', '壹', '貳', '參', '肆', '伍', '陸', '柒', '捌', '玖'];

    public char C10
        => '拾';

    public char C100
        => '佰';

    public char C1_000
        => '仟';

    public char C10_000
        => '萬';

    public char C100_000_000
        => '億';
}