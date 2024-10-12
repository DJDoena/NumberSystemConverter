using DoenaSoft.NumberSystemConverter.EastAsia;
using NC = DoenaSoft.NumberSystemConverter.EastAsia.NumeralConstants;

namespace DoenaSoft.NumberSystemConverter.Japanese;

internal sealed class ToConverter(I10p4NumeralCharacters numeralCharacters)
    : To10p4ConverterBase(numeralCharacters)
{
    private const char C0A = '〇';

    private static readonly Dictionary<char, ulong> _alternates = new()
    {
        { C0A, 0 },
    };

    protected override void ContainsSpecialCharacter(string input
        , ulong factor
        , ref string[] split
        , out bool containsSpecialCharacter
        , out char foundSpecialCharacter
        , out ulong characterValue)
    {
        containsSpecialCharacter = false;
        foundSpecialCharacter = '\0';
        characterValue = 0UL;

        switch (factor)
        {
            case NC.D1000:
                {
                    if (string.IsNullOrEmpty(split[0]))
                    {
                        split[0] = _numeralCharacters.SingleDigits[1].ToString();
                    }

                    break;
                }
            case NC.D100:
                {
                    if (string.IsNullOrEmpty(split[0]))
                    {
                        split[0] = _numeralCharacters.SingleDigits[1].ToString();
                    }

                    break;
                }
        }
    }

    protected override IEnumerable<char> GetAlternates()
        => _alternates.Keys;

    protected override char[] GetAlternateZeroCharacters()
        => [C0A];

    protected override bool TryGetAlternateCharacter(char character, out ulong value)
        => _alternates.TryGetValue(character, out value);
}