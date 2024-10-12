using DoenaSoft.NumberSystemConverter.EastAsia;

namespace DoenaSoft.NumberSystemConverter.Japanese;

public abstract class NumeralCharacterBase : I10p4NumeralCharacters
{
    public abstract char[] SingleDigits { get; }

    public abstract char C10 { get; }

    public abstract char C100 { get; }

    public abstract char C1000 { get; }

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