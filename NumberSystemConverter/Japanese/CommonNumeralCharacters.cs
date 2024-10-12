namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class CommonNumeralCharacters : NumeralCharacterBase
{
    public override char[] SingleDigits
        => ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九'];

    public override char C10
        => '十';

    public override char C100
        => '百';

    public override char C1000
        => '千';
}