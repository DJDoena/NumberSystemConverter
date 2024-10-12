using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Japanese;

public sealed class NumeralCharacters : I10p4NumeralCharacters
{
    public char[] SingleDigits
        => ['零', '一', '二', '三', '四', '五', '六', '七', '八', '九'];

    public char C10
        => '十';

    public char C100
        => '百';

    public char C1000
        => '千';

    public char C1_0000
        => '万';

    public char C1_0000_0000
        => '億';

    public char C1_0000_0000_0000
        => '兆';

    public char C1_0000_0000_0000_0000
        => '京';

    public char C1_0000_0000_0000_0000_0000
        => '垓';
}