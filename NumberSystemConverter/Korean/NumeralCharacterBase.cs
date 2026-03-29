using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Korean;

public abstract class NumeralCharacterBase : I10p4NumeralCharacters
{
    public abstract char[] SingleDigits { get; }

    public abstract char C10 { get; }

    public abstract char C100 { get; }

    public abstract char C1000 { get; }

    public char C1_0000
        => '만';

    public char C1_0000_0000
        => '억';

    public char C1_0000_0000_0000
        => '조';

    public char C1_0000_0000_0000_0000
        => '경';

    public char C1_0000_0000_0000_0000_0000
        => '해';
}
