namespace DoenaSoft.NumberSystemConverter.Chinese;

public sealed class FinancialTraditionalNumeralCharacters : NumeralCharactersBase
{
    public override char[] SingleDigits
        => ['零', '壹', '貳', '參', '肆', '伍', '陸', '柒', '捌', '玖'];

    public override char C10
        => '拾';

    public override char C100
        => '佰';

    public override char C1000
        => '仟';

    public override char C1_0000
        => '萬';

    public override char C1_0000_0000
        => '億';
}