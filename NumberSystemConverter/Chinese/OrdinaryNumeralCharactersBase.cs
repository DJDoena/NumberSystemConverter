namespace DoenaSoft.NumberSystemConverter.Chinese;

public abstract class OrdinaryNumeralCharactersBase : INumeralCharacters
{
    public char[] SingleDigits
        => ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九'];

    public char C10
        => '十';

    public char C100
        => '百';

    public char C1_000
        => '千';

    public abstract char C10_000 { get; }

    public abstract char C100_000_000 { get; }
}