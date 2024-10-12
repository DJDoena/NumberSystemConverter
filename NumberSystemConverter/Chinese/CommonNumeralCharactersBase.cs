namespace DoenaSoft.NumberSystemConverter.Chinese;

public abstract class CommonNumeralCharactersBase : NumeralCharactersBase
{
    public sealed override char[] SingleDigits
        => ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九'];

    public sealed override char C10
        => '十';

    public sealed override char C100
        => '百';

    public sealed override char C1000
        => '千';
}