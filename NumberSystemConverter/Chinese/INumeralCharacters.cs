namespace DoenaSoft.NumberSystemConverter.Chinese;

public interface INumeralCharacters
{
    char[] SingleDigits { get; }

    char C10 { get; }

    char C100 { get; }

    char C1_000 { get; }

    char C10_000 { get; }

    char C100_000_000 { get; }
}